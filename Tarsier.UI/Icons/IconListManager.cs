﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Tarsier.UI.Icons {
    /// <summary>
	/// Maintains a list of currently added file extensions
	/// </summary>
	public class IconListManager {
        private Hashtable _extensionList = new Hashtable();
        private ArrayList _imageLists = new ArrayList();         //will hold ImageList objects
        private IconReader.IconSize _iconSize;
        bool ManageBothSizes = false; //flag, used to determine whether to create two ImageLists.

        /// <summary>
        /// Creates an instance of <c>IconListManager</c> that will add icons to a single <c>ImageList</c> using the
        /// specified <c>IconSize</c>.
        /// </summary>
        /// <param name="imageList"><c>ImageList</c> to add icons to.</param>
        /// <param name="iconSize">Size to use (either 32 or 16 pixels).</param>
        public IconListManager(ImageList imageList, IconReader.IconSize iconSize) {
            // Initialise the members of the class that will hold the image list we're
            // targeting, as well as the icon size (32 or 16)
            _imageLists.Add(imageList);
            _iconSize = iconSize;
        }

        /// <summary>
        /// Creates an instance of IconListManager that will add icons to two <c>ImageList</c> types. The two
        /// image lists are intended to be one for large icons, and the other for small icons.
        /// </summary>
        /// <param name="smallImageList">The <c>ImageList</c> that will hold small icons.</param>
        /// <param name="largeImageList">The <c>ImageList</c> that will hold large icons.</param>
        public IconListManager(System.Windows.Forms.ImageList smallImageList, System.Windows.Forms.ImageList largeImageList) {
            //add both our image lists
            _imageLists.Add(smallImageList);
            _imageLists.Add(largeImageList);

            //set flag
            ManageBothSizes = true;
        }

        /// <summary>
        /// Used internally, adds the extension to the hashtable, so that its value can then be returned.
        /// </summary>
        /// <param name="Extension"><c>String</c> of the file's extension.</param>
        /// <param name="ImageListPosition">Position of the extension in the <c>ImageList</c>.</param>
        private void AddExtension(string Extension, int ImageListPosition) {
            if(!_extensionList.Contains(Extension)) {
                _extensionList.Add(Extension, ImageListPosition);
            }
        }

        /// <summary>
        /// Called publicly to add a file's icon to the ImageList.
        /// </summary>
        /// <param name="filePath">Full path to the file.</param>
        /// <returns>Integer of the icon's position in the ImageList</returns>
        public int AddFileIcon(string filePath) {
            // Check if the file exists, otherwise, throw exception.
            if(!File.Exists(filePath)) throw new FileNotFoundException("File does not exist");

            // Split it down so we can get the extension
            string[] splitPath = filePath.Split(new Char[] { '.' });
            string extension = (string)splitPath.GetValue(splitPath.GetUpperBound(0));

            //Check that we haven't already got the extension, if we have, then
            //return back its index
            if(_extensionList.ContainsKey(extension.ToUpper())) {
                // To make sure all EXE files are not the same Icon
                if(extension.ToUpper().Equals("EXE") || extension.ToUpper().Equals(".EXE")) {
                    return ResolveExeFile(extension, filePath);
                }
                return (int)_extensionList[extension.ToUpper()];        //return existing index
            } else {
                // It's not already been added, so add it and record its position.
                return GetPosition(extension, filePath);
            }
        }

        private int ResolveExeFile(string extension, string filePath) {
            string newExtension = Path.GetFileName(filePath);
            Regex regex = new Regex("[^a-zA-Z0-9]");
            extension = regex.Replace(newExtension, string.Empty);
            return GetPosition(extension, filePath);
        }
        private int GetPosition(string extension, string filePath) {
            int pos = ((ImageList)_imageLists[0]).Images.Count;     //store current count -- new item's index

            if(ManageBothSizes == true) {
                //managing two lists, so add it to small first, then large
                ((ImageList)_imageLists[0]).Images.Add(IconReader.GetFileIcon(filePath, IconReader.IconSize.Small, false));
                ((ImageList)_imageLists[1]).Images.Add(IconReader.GetFileIcon(filePath, IconReader.IconSize.Large, false));
            } else {
                //only doing one size, so use IconSize as specified in _iconSize.
                try {
                    ((ImageList)_imageLists[0]).Images.Add(IconReader.GetFileIcon(filePath, _iconSize, false)); //add to image list
                } catch (Exception ex) {
                    throw ex;
                }
            }

            AddExtension(extension.ToUpper(), pos); // add to hash table
            return pos;
        }
        /// <summary>
        /// Clears any <c>ImageLists</c> that <c>IconListManager</c> is managing.
        /// </summary>
        public void ClearLists() {
            foreach(ImageList imageList in _imageLists) {
                imageList.Images.Clear();   //clear current imagelist.
            }

            _extensionList.Clear();         //empty hashtable of entries too.
        }
    }
}
