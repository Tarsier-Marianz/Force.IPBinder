﻿using System;
using System.Text.RegularExpressions;

namespace Tarsier.Extensions
{
    public static class StringUtils {
        public static String ToSafeString(this object obj) {
            return obj != null ? obj.ToString().Trim() : String.Empty;
        }

        public static String ToStringType(this String value) {
            return String.Format("'{0}'", value.EscapeQuote());
        }

        public static string ToTriggerString(this string argValue, string defaultValue) {
            return string.IsNullOrEmpty(argValue.ToSafeString()) ? defaultValue : argValue;
        }

        public static String EscapeQuote(this String value) {
            value = value.ToSafeString().Trim();
            if(!(String.IsNullOrEmpty(value))) {
                return value.Replace("'", "''");
            }
            return String.Empty;
        }

        public static string RemoveNonAlphaNumeric(this object value) {
            return value.ToSafeString().RemoveNonAlphaNumeric();
        }

        public static string RemoveNonAlphaNumeric(this string value) {
            Regex regex = new Regex("[^a-zA-Z0-9]");
            if(!(string.IsNullOrEmpty(value))) {
                return regex.Replace(value, string.Empty);
            }
            return string.Empty;
        }

        public static string TrimMutilinesString(this string value) {
            return Regex.Replace(value, @"\s+", " ");
        }
        public static string TrimDashes(this string value) {
            if(String.IsNullOrEmpty(value)) {
                return String.Empty;
            }
            return Regex.Replace(value.Trim(), "-{2,}", "-");
        }

        public static string TrimUnderscore(this string value) {
            if(String.IsNullOrEmpty(value)) {
                return String.Empty;
            }
            return Regex.Replace(value.Trim(), "_{2,}", "_");
        }
        public static string ReplaceUnderscore(this string value) {
            if(String.IsNullOrEmpty(value)) {
                return String.Empty;
            }
            return Regex.Replace(value.TrimDashes(), "-", "_");
        }
        public static string RemoveSpaces(this string value) {
            if(String.IsNullOrEmpty(value)) {
                return String.Empty;
            }
            return value.Trim().Replace(" ", "");
        }

        public static string ParseDollarSign(this string sheetName) {
            if(String.IsNullOrEmpty(sheetName)) {
                return String.Empty;
            }
            string[] array = sheetName.Split(new char[] { '$' });
            return array[0];
        }

        public static string ToAlphaOnly(this string input) {
            Regex rgx = new Regex("[^a-zA-Z]");
            return rgx.Replace(input, "");
        }

        public static string ToNumericOnly(this string input) {
            Regex rgx = new Regex("[^0-9]");
            return rgx.Replace(input, "");
        }

        public static string GetTabs(this int count) {
            return RepeatChar('\t', count);
        }

        public static string GetSpaces(this int count) {
            return RepeatChar(' ', count);
        }

        public static string RepeatChar(this char character, int count) {
            count = (count < 0) ? 0 : count;
            return new String(character, count);
        }

        public static string TruncatePath(this string path) {
            if(Regex.IsMatch(path, "^(\\w+:|\\\\)(\\\\[^\\\\]+\\\\).*(\\\\[^\\\\]+\\\\[^\\\\]+)$"))
                return Regex.Replace(path, "^(\\w+:|\\\\)(\\\\[^\\\\]+\\\\).*(\\\\[^\\\\]+\\\\[^\\\\]+)$", "$1$2...$3");
            return path;
        }

        public static string TruncateString(this string value, int maxChars) {
            return value.Length <= maxChars ? value : value.Substring(0, maxChars) + "...";
        }
        public static string ToValidPath(this string value) {
            Regex regex = new Regex("[^a-zA-Z0-9 /_]+");
            return regex.Replace(value, string.Empty).TrimMutilinesString();
        }
    }
}
