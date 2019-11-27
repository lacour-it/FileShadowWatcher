using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Data;
using System.IO;
using System.Reflection;
using System.Net;
using System.Security.Cryptography;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace FileShadowWatcherShared
{
    public static class Extensions
    {
        #region Object
        public static bool IsNullOrDBNull(this object source)
        {
            return (source == null || source.GetType() == typeof(DBNull)) ? true : false;
        }


#endregion
        #region Numeric

        public static int ConvertFromMM(this int margin)
        {
            return Convert.ToInt32(10 / 2.54 * margin);
        }

        public static bool In(this int Number, ICollection<int> Numbers)
        {
            return Numbers.Any(n => n == Number);
        }
        #endregion

        #region Strings


        public static bool IsNumeric(this string instance)
        {
            Regex pattern = new Regex(@"^[0-9,.]+$");
            return pattern.IsMatch(instance.Trim());
        }

        public static bool IsNullOrWhiteSpace(this string instance)
        {

            // Eigene Implementierung verwenden, um Kompatibilität zu früheren Versionen zu behalten
            if (instance != null)
            {
                for (int i = 0; i < instance.Length; i++)
                {
                    if (instance[i] != ' ')
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public static bool IsNull(this object source)
        {
            return (source == null) ? true : false;
        }

        public static bool IsNullOrEmpty(this string source)
        {
            return String.IsNullOrEmpty(source);
        }

        public static bool IsNullOrDBNull(this string source)
        {
            return (source == null || source.GetType() == typeof(DBNull)) ? true : false;
        }

        public static bool IsNullOrEmptyOrDBNull(this string source)
        {
            return (String.IsNullOrEmpty(source) || source.GetType() == typeof(DBNull)) ? true : false;
        }

        public static string AddString(this string source, string thatstring, string adder)
        {
            return adder.IsNullOrEmpty() ? source + thatstring : source + adder + thatstring;
        }

        public static string AddString(this string source, string thatstring)
        {
            return source + " " + thatstring;
        }

        /// <summary>
        /// Wandelt einen String in einen Base64-String um
        /// </summary>
        /// <param name="toEncode"></param>
        /// <returns></returns>
        public static string EncodeTo64(this string toEncode)
        {
            byte[] toEncodeAsBytes
                  = System.Text.ASCIIEncoding.Default.GetBytes(toEncode);
            string returnValue
                  = System.Convert.ToBase64String(toEncodeAsBytes);
            return returnValue;
        }

        /// <summary>
        /// Wandelt einen String in einen Base64-String um
        /// </summary>
        /// <param name="toEncode"></param>
        /// <returns></returns>
        public static string EncodeTo64(this string toEncode, Encoding encoding)
        {
            byte[] toEncodeAsBytes
                  = encoding.GetBytes(toEncode);
            string returnValue
                  = System.Convert.ToBase64String(toEncodeAsBytes);
            return returnValue;
        }

        /// <summary>
        /// Wandelt einen Base64 codiert String in einen Standard-String um.
        /// </summary>
        /// <param name="encodedData"></param>
        /// <returns></returns>
        public static string DecodeFrom64(this string encodedData)
        {
            byte[] encodedDataAsBytes
                = System.Convert.FromBase64String(encodedData);
            string returnValue =
               System.Text.ASCIIEncoding.Default.GetString(encodedDataAsBytes);
            return returnValue;
        }

        /// <summary>
        /// Wandelt einen Base64 codiert String in einen Standard-String um.
        /// </summary>
        /// <param name="encodedData"></param>
        /// <returns></returns>
        public static string DecodeFrom64(this string encodedData, Encoding encoding)
        {
            byte[] encodedDataAsBytes
                = System.Convert.FromBase64String(encodedData);
            string returnValue =
               encoding.GetString(encodedDataAsBytes);
            return returnValue;
        }

        /// <summary>
        /// Encrypts the string.
        /// </summary>
        /// <param name="clearText">The clear text.</param>
        /// <param name="Key">The key.</param>
        /// <param name="IV">The IV.</param>
        /// <returns></returns>
        private static byte[] EncryptString(byte[] clearText, byte[] Key, byte[] IV)
        {
            MemoryStream ms = new MemoryStream();
            Rijndael alg = Rijndael.Create();
            alg.Key = Key;
            alg.IV = IV;
            CryptoStream cs = new CryptoStream(ms, alg.CreateEncryptor(), CryptoStreamMode.Write);
            cs.Write(clearText, 0, clearText.Length);
            cs.Close();
            byte[] encryptedData = ms.ToArray();
            return encryptedData;
        }

        /// <summary>
        /// Encrypts the string.
        /// </summary>
        /// <param name="clearText">The clear text.</param>
        /// <param name="Password">The password.</param>
        /// <returns></returns>
        public static string EncryptString(this string clearText, string Password)
        {
            byte[] clearBytes = System.Text.Encoding.Unicode.GetBytes(clearText);
            PasswordDeriveBytes pdb = new PasswordDeriveBytes(Password, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
            byte[] encryptedData = EncryptString(clearBytes, pdb.GetBytes(32), pdb.GetBytes(16));
            return Convert.ToBase64String(encryptedData);
        }

        /// <summary>
        /// Decrypts the string.
        /// </summary>
        /// <param name="cipherData">The cipher data.</param>
        /// <param name="Key">The key.</param>
        /// <param name="IV">The IV.</param>
        /// <returns></returns>
        private static byte[] DecryptString(byte[] cipherData, byte[] Key, byte[] IV)
        {
            MemoryStream ms = new MemoryStream();
            Rijndael alg = Rijndael.Create();
            alg.Key = Key;
            alg.IV = IV;
            CryptoStream cs = new CryptoStream(ms, alg.CreateDecryptor(), CryptoStreamMode.Write);
            cs.Write(cipherData, 0, cipherData.Length);
            cs.Close();
            byte[] decryptedData = ms.ToArray();
            return decryptedData;
        }

        /// <summary>
        /// Decrypts the string.
        /// </summary>
        /// <param name="cipherText">The cipher text.</param>
        /// <param name="Password">The password.</param>
        /// <returns></returns>
        public static string DecryptString(this string cipherText, string Password)
        {
            byte[] cipherBytes = Convert.FromBase64String(cipherText);
            PasswordDeriveBytes pdb = new PasswordDeriveBytes(Password, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
            byte[] decryptedData = DecryptString(cipherBytes, pdb.GetBytes(32), pdb.GetBytes(16));
            return System.Text.Encoding.Unicode.GetString(decryptedData);
        }
        public static bool IsEmail(this string instance)
        {
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}"
              + @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\"
              + @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";

            Regex pattern = new Regex(strRegex);

            return (pattern.IsMatch(instance)) ? true : false;
        }

        public static string ToUpperCaseFirstChar(this string input) // Erweiterung
        {
            if (input.IsNullOrEmpty())
                return "";

            return input[0].ToString().ToUpper() + input.Substring(1).ToLower();
        }

        public static string TrimAndReduce(this string value)
        {
            return Regex.Replace(value, @"\s+", " ");
        }

        public static string TrimAndReplace(this string value, string toReplace)
        {
            return Regex.Replace(value, @"\s+", toReplace);
        }

        public static int WordCount(this String str)
        {
            return str.Split(new char[] { ' ', '.', '?', ';', ':' },
                             StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public static bool CanConvertToInt32(this String instance)
        {
            int convertedString = -1;
            return Int32.TryParse(instance, out convertedString);
        }

        public static int ToInt32(this String instance)
        {
            int convertedString = -1;
            if (Int32.TryParse(instance, out convertedString))
                return convertedString;
            else
                throw new ArgumentException("This string instance can not be converted to Int32");
        }

        public static int? ToInt32Nullable(this String instance)
        {
            int convertedString = -1;
            if (Int32.TryParse(instance, out convertedString))
                return convertedString;
            else
                return null;
        }

        public static string ClearTextField(this string instance)
        {
            string outstr = "";
            Regex regx = new Regex("[;,\t|]");
            string repl = " ";
            outstr = regx.Replace(instance, repl);
            return outstr;
        }

        public static string RegexReplace(this string instance, string pattern, string replacement)
        {
            string outstr = "";
            Regex regx = new Regex(pattern);
            outstr = regx.Replace(instance, replacement);
            return outstr;
        }

        public static T ToEnum<T>(this string value) where T : struct
        {
            return (T)System.Enum.Parse(typeof(T), value, true);
        }

        /// <summary>
        /// Returns characters from right of specified length
        /// </summary>
        /// <param name="value">String value</param>
        /// <param name="length">Max number of charaters to return</param>
        /// <returns>Returns string from right</returns>
        public static string Right(this string value, int length)
        {
            return value != null && value.Length > length ? value.Substring(value.Length - length) : value;
        }

        /// <summary>
        /// Returns characters from left of specified length
        /// </summary>
        /// <param name="value">String value</param>
        /// <param name="length">Max number of charaters to return</param>
        /// <returns>Returns string from left</returns>
        public static string Left(this string value, int length)
        {
            return value != null && value.Length > length ? value.Substring(0, length) : value;
        }

        public static string RemoveBlanks(string s)
        {
            return (s != null) ? s.Replace(" ", "") : "";
        }

        /// <summary>
        /// An enumeration of the types of masking styles for the Mask() extension method
        /// of the string class.
        /// </summary>
        public enum MaskStyle
        {
            /// <summary>
            /// Masks all characters within the masking region, regardless of type.
            /// </summary>
            All,

            /// <summary>
            /// Masks only alphabetic and numeric characters within the masking region.
            /// </summary>
            AlphaNumericOnly,
        }

        /// <summary>
        /// Utility class for string manipulation.
        /// </summary>
        /// <summary>
        /// Default masking character used in a mask.
        /// </summary>
        public static readonly char DefaultMaskCharacter = '*';


        /// <summary>
        /// Returns true if the string is non-null and at least the specified number of characters.
        /// </summary>
        /// <param name="value">The string to check.</param>
        /// <param name="length">The minimum length.</param>
        /// <returns>True if string is non-null and at least the length specified.</returns>
        /// <exception>throws ArgumentOutOfRangeException if length is not a non-negative number.</exception>
        public static bool IsLengthAtLeast(this string value, int length)
        {
            if (length < 0)
            {
                throw new ArgumentOutOfRangeException("length", length,
                                                        "The length must be a non-negative number.");
            }

            return value != null
                        ? value.Length >= length
                        : false;
        }

        public enum SplittedStringOption
        {
            Begin, Numeric, End
        }
        public static string GetSplittedStringAt(this string StringToSplitt, char Splitter, SplittedStringOption Option, int Number = 0)
        {
            string[] splittedString = StringToSplitt.Split(Splitter);
            if (Option == SplittedStringOption.End)
                Number = splittedString.Length - 1;
            return splittedString[Number];
        }

        /// <summary>
        /// Validates the password.
        /// </summary>
        /// <param name="passwordToValidate">The password to validate.</param>
        /// <param name="minimumPasswordLength">Minimum length of the password.</param> 
        /// <param name="minimumNumberOfSpecialCharaters">The minimum number of special charaters.</param> 
        /// <param name="minimumNumberOfUpperCaseCharaters">The minimum number of upper case charaters.</param> 
        /// <param name="minimumNumberOfLowerCaseCharaters">The minimum number of lower case charaters.</param> 
        /// <param name="minimumNumberOfNumericCharaters">The minimum number of numeric charaters.</param> 
        /// <returns></returns> 
        public static bool ValidatePassword(string passwordToValidate, int minimumPasswordLength, int minimumNumberOfSpecialCharaters, int minimumNumberOfUpperCaseCharaters, int minimumNumberOfLowerCaseCharaters, int minimumNumberOfNumericCharaters)
        {
            if (passwordToValidate == null || passwordToValidate.Length < minimumPasswordLength)
                return false;

            int numberOfSpecialCharaters = 0;
            int numberOfLowerCaseCharaters = 0;
            int numberOfUpperCaseCharaters = 0;
            int numberOfNumericCharaters = 0;

            var regexSpecialCharater = new Regex("[^A-Za-z0-9]");
            var regexLowerCaseCharater = new Regex("[a-z]");
            var regexUpperCaseCharater = new Regex("[A-Z]");
            var regexNumericCharaters = new Regex("[0-9]");

            for (int i = 0; i < passwordToValidate.Length; i++)
            {
                if (regexSpecialCharater.IsMatch(passwordToValidate[i].ToString()))
                    numberOfSpecialCharaters++;

                if (regexLowerCaseCharater.IsMatch(passwordToValidate[i].ToString()))
                    numberOfLowerCaseCharaters++;

                if (regexUpperCaseCharater.IsMatch(passwordToValidate[i].ToString()))
                    numberOfUpperCaseCharaters++;

                if (regexNumericCharaters.IsMatch(passwordToValidate[i].ToString()))
                    numberOfNumericCharaters++;
            }

            return (numberOfSpecialCharaters >= minimumNumberOfSpecialCharaters)
                   && (numberOfLowerCaseCharaters >= minimumNumberOfLowerCaseCharaters)
                   && (numberOfUpperCaseCharaters >= minimumNumberOfUpperCaseCharaters)
                   && (numberOfNumericCharaters >= minimumNumberOfNumericCharaters);
        }
        #endregion

        #region Exception.ToLogString
        public static string ToLogString(this Exception ex, string additionalMessage)
        {
            StringBuilder msg = new StringBuilder();

            if (!additionalMessage.IsNullOrEmpty())
            {
                msg.Append(additionalMessage);
                msg.Append(Environment.NewLine);
            }

            if (ex != null)
            {
                try
                {
                    Exception orgEx = ex;

                    msg.Append("Exception:");
                    msg.Append(Environment.NewLine);
                    while (orgEx != null)
                    {
                        msg.Append(orgEx.Message);
                        msg.Append(Environment.NewLine);
                        orgEx = orgEx.InnerException;
                    }

                    if (!ex.Data.IsNull())
                    {
                        foreach (object i in ex.Data)
                        {
                            msg.Append("Data :");
                            msg.Append(i.ToString());
                            msg.Append(Environment.NewLine);
                        }
                    }

                    if (!ex.StackTrace.IsNull())
                    {
                        msg.Append("StackTrace:");
                        msg.Append(Environment.NewLine);
                        msg.Append(ex.StackTrace.ToString());
                        msg.Append(Environment.NewLine);
                    }

                    if (!ex.Source.IsNull())
                    {
                        msg.Append("Source:");
                        msg.Append(Environment.NewLine);
                        msg.Append(ex.Source);
                        msg.Append(Environment.NewLine);
                    }

                    if (!ex.TargetSite.IsNull())
                    {
                        msg.Append("TargetSite:");
                        msg.Append(Environment.NewLine);
                        msg.Append(ex.TargetSite.ToString());
                        msg.Append(Environment.NewLine);
                    }

                    Exception baseException = ex.GetBaseException();
                    if (baseException != null)
                    {
                        msg.Append("BaseException:");
                        msg.Append(Environment.NewLine);
                        msg.Append(ex.GetBaseException());
                    }
                }
                finally
                {
                }
            }
            return msg.ToString();
        }
        #endregion Exception.ToLogString



        #region DateTime
        public enum DateTimeSpecialString
        {
            TimeStamp, DateStamp, DateTimeStamp, TimeStampReverse, DateStampReverse, DateTimeStampReverse, DateTimeStampReverseFull , DateWithFullDayName, QueryFormat1, QueryFormat2, IsoFormat
        }

        public static decimal TimeSpanMinutesToDecimal(this TimeSpan dt)
        {
            decimal p = 100 / 60;
            return dt.Minutes * p;
        }

        public static decimal TimeSpanMinutesToInvoiceDecimal(this TimeSpan dt)
        {
            decimal p = 100 / 60;
            decimal i = dt.Minutes * p;
            decimal r = 0.00m;
            if (i > 0 && i < 15)
                r = 0.15m;
            if (i > 15 && i < 30)
                r = 0.30m;
            if (i > 30 && i < 45)
                r = 0.45m;
            if (i > 45 && i < 60)
                r = 1.00m;
            return r;
        }

        public static string ToSpecialString(this DateTime dt, DateTimeSpecialString spezString)
        {
            string returnDate = dt.ToString();
            string dformat = "";
            switch (spezString)
            {
                case DateTimeSpecialString.TimeStamp:
                    dformat = "hhmmss";
                    break;
                case DateTimeSpecialString.DateStamp:
                    dformat = "yyyyMMdd";
                    break;
                case DateTimeSpecialString.DateTimeStamp:
                    dformat = "ddMMyyyyhhmmss";
                    break;
                case DateTimeSpecialString.TimeStampReverse:
                    dformat = "";
                    break;
                case DateTimeSpecialString.DateStampReverse:
                    dformat = "yyyyMMdd";
                    break;
                case DateTimeSpecialString.DateTimeStampReverse:
                    dformat = "yyyyMMddhhmm";
                    break;
                case DateTimeSpecialString.DateTimeStampReverseFull:
                    dformat = "yyyyMMddhhmmss";
                    break;
                case DateTimeSpecialString.DateWithFullDayName:
                    dformat = "dddd, dd.MM.yyyy";
                    break;
                case DateTimeSpecialString.QueryFormat1:
                    dformat = "yyyy-MM-dd";
                    break;
                case DateTimeSpecialString.QueryFormat2:
                    dformat = "MM/dd/yyyy";
                    break;
                case DateTimeSpecialString.IsoFormat:
                    dformat = "yyyy-MM-dd HH:mm:ss";
                    break;
                default:
                    break;
            }
            returnDate = dt.ToString(dformat);
            return returnDate;
        }


        public static bool Intersects(this DateTime startDate, DateTime endDate, DateTime intersectingStartDate, DateTime intersectingEndDate)
        {
            return (intersectingEndDate >= startDate && intersectingStartDate <= endDate);
        }
        public static DateTime GetLastDayOfMonth(this DateTime dateTime)
        {
            return new DateTime(dateTime.Year, dateTime.Month, 1).AddMonths(1).AddDays(-1);
        }
        #endregion

        #region Data

        public static List<string> ToCSV(this IDataReader dataReader, bool includeHeaderAsFirstRow, string separator)
        {
            List<string> csvRows = new List<string>();
            StringBuilder sb = null;

            if (includeHeaderAsFirstRow)
            {
                sb = new StringBuilder();
                for (int index = 0; index < dataReader.FieldCount; index++)
                {
                    if (dataReader.GetName(index) != null)
                        sb.Append(dataReader.GetName(index));

                    if (index < dataReader.FieldCount - 1)
                        sb.Append(separator);
                }
                csvRows.Add(sb.ToString());
            }

            while (dataReader.Read())
            {
                sb = new StringBuilder();
                for (int index = 0; index < dataReader.FieldCount - 1; index++)
                {
                    if (!dataReader.IsDBNull(index))
                    {
                        string value = dataReader.GetValue(index).ToString();
                        if (dataReader.GetFieldType(index) == typeof(String))
                        {
                            //If double quotes are used in value, ensure each are replaced but 2.
                            if (value.IndexOf("\"") >= 0)
                                value = value.Replace("\"", "\"\"");

                            //If separtor are is in value, ensure it is put in double quotes.
                            if (value.IndexOf(separator) >= 0)
                                value = "\"" + value + "\"";
                        }
                        sb.Append(value);
                    }

                    if (index < dataReader.FieldCount - 1)
                        sb.Append(separator);
                }

                if (!dataReader.IsDBNull(dataReader.FieldCount - 1))
                    sb.Append(dataReader.GetValue(dataReader.FieldCount - 1).ToString().Replace(separator, " "));

                csvRows.Add(sb.ToString());
            }
            dataReader.Close();
            sb = null;
            return csvRows;
        }

        public static void WriteToCSV(this DataTable datatable, string path, char seperator, bool hasHeadlines, Encoding encoding, List<ExportField> exportFields, bool leaveEmpty = true)
        {
            ExtensionHelper eh = new ExtensionHelper();
            using (StreamWriter sw = new StreamWriter(path, false, encoding))
            {
                int numberOfColumns = datatable.Columns.Count;

                if (hasHeadlines)
                {
                    for (int i = 0; i < numberOfColumns; i++)
                    {
                        if (eh.IsItemExport(datatable.Columns[i].ColumnName, exportFields))
                        {
                            sw.Write(datatable.Columns[i]);
                            if (i < numberOfColumns - 1)
                                sw.Write(seperator);
                        }
                        else
                        {
                            if (leaveEmpty)
                            {
                                sw.Write(datatable.Columns[i]);
                                if (i < numberOfColumns - 1)
                                    sw.Write(seperator);
                            }
                        }
                    }
                    sw.Write(sw.NewLine);
                }

                foreach (DataRow dr in datatable.Rows)
                {
                    for (int i = 0; i < numberOfColumns; i++)
                    {
                        // if (datatable.Columns[i].DataType == typeof(Decimal))
                        // {
                        //     dr[i].ToString().
                        // }
                        if (eh.IsItemExport(datatable.Columns[i].ColumnName, exportFields))
                        {
                                if (datatable.Columns[i].DataType == typeof(Decimal))
                                {
                                    if (dr[i] == DBNull.Value)
                                    {
                                        sw.Write(0.00);
                                    }
                                    else
                                    {
                                        Decimal md = Convert.ToDecimal(dr[i]);
                                        string ms = Convert.ToString(md, System.Globalization.CultureInfo.InvariantCulture);
                                        sw.Write(ms);
                                    }
                            }

                            if (i < numberOfColumns - 1)
                                sw.Write(seperator);
                        }
                        else
                        {
                            if (leaveEmpty)
                            {
                                if (i < numberOfColumns - 1)
                                    sw.Write(seperator);
                            }
                        }
                    }
                    sw.Write(sw.NewLine);
                }
            }
        }

        #endregion

        #region EnumerationsAndCollections

        public static string ToDelimited<T>(this IEnumerable<T> list, string delimiter)
        {
            Type mytype = typeof(T);
            PropertyInfo[] infos = mytype.GetProperties();
            string line = "";

            foreach (T item in list)
            {
                for (int i = 0; i < infos.Length; i++)
                {
                    PropertyInfo info = infos[i];
                    line = line + info.GetValue(item, null).ToString() + delimiter;
                }
                line = line.Substring(0, line.Length - delimiter.Length - 1) + Environment.NewLine;
            }
            return line;
        }

        public static string[] ToDelimitedArray<T>(this IEnumerable<T> list, string delimiter)
        {
            List<string> newList = new List<string>();
            Type mytype = typeof(T);
            PropertyInfo[] infos = mytype.GetProperties();

            foreach (T item in list)
            {
                string line = "";
                for (int i = 0; i < infos.Length; i++)
                {
                    PropertyInfo info = infos[i];
                    line = line + info.GetValue(item, null).ToString() + delimiter;
                }
                line = line.Substring(0, line.Length - delimiter.Length - 1) + Environment.NewLine;
                newList.Add(line);
            }
            return newList.ToArray();
        }

        public static IEnumerable<T> OrderBy<T>(this IEnumerable<T> list, string sortExpression)
        {
            sortExpression += "";
            string[] parts = sortExpression.Split(' ');
            bool descending = false;
            string property = "";

            if (parts.Length > 0 && parts[0] != "")
            {
                property = parts[0];

                if (parts.Length > 1)
                {
                    descending = parts[1].ToLower().Contains("esc");
                }

                PropertyInfo prop = typeof(T).GetProperty(property);

                if (prop == null)
                {
                    return list;
                }

                if (descending)
                    return list.OrderByDescending(x => prop.GetValue(x, null));
                else
                    return list.OrderBy(x => prop.GetValue(x, null));
            }

            return list;
        }

        public static void ForEach<T>(this IEnumerable<T> source, Action<T> action)
        {
            foreach (var item in source)
                action(item);
        }

        public static DataTable ToDataTable<T>(this IEnumerable<T> varlist)
        {
            DataTable dtReturn = new DataTable();

            // column names 
            PropertyInfo[] oProps = null;

            if (varlist == null) return dtReturn;

            foreach (T rec in varlist)
            {
                // Use reflection to get property names, to create table, Only first time, others will follow 
                if (oProps == null)
                {
                    oProps = ((Type)rec.GetType()).GetProperties();
                    foreach (PropertyInfo pi in oProps)
                    {
                        Type colType = pi.PropertyType;

                        if ((colType.IsGenericType) && (colType.GetGenericTypeDefinition() == typeof(Nullable<>)))
                        {
                            colType = colType.GetGenericArguments()[0];
                        }

                        dtReturn.Columns.Add(new DataColumn(pi.Name, colType));
                    }
                }

                DataRow dr = dtReturn.NewRow();

                foreach (PropertyInfo pi in oProps)
                {
                    dr[pi.Name] = pi.GetValue(rec, null) == null ? DBNull.Value : pi.GetValue
                    (rec, null);
                }

                dtReturn.Rows.Add(dr);
            }
            return dtReturn;
        }

        public static IEnumerable<T> Slice<T>(this IEnumerable<T> collection, int start, int end)
        {
            int index = 0;
            int count = 0;

            if (collection == null)
                throw new ArgumentNullException("collection");

            // Optimise item count for ICollection interfaces.
            if (collection is ICollection<T>)
                count = ((ICollection<T>)collection).Count;
            else if (collection is ICollection<T>)
                count = ((ICollection<T>)collection).Count;
            else
                count = collection.Count();

            // Get start/end indexes, negative numbers start at the end of the collection.
            if (start < 0)
                start += count;

            if (end < 0)
                end += count;

            foreach (var item in collection)
            {
                if (index >= end)
                    yield break;

                if (index >= start)
                    yield return item;

                ++index;
            }
        }

        #endregion

        #region XML and JSON
        /// <summary>
        /// Speichert ein Objekt im einer XML-Datei unter Angabe des Pfades, des zu speichernden Objekts und des 
        /// Objekttypen. 
        /// </summary>
        /// <param name="path"></param>
        /// <param name="myObject"></param>
        /// <param name="myType"></param>
        public static void SaveToXML(this object Object, string path)
        {
            Type myType = Object.GetType();
            XmlSerializer mySerializer = new XmlSerializer(myType);
            StreamWriter myWriter = new StreamWriter(path);
            mySerializer.Serialize(myWriter, Object);
            myWriter.Close();
        }

        /// <summary>
        /// Lädt ein Objekt aus einer mit SaveToXML gespeicherten Datei
        /// Bsp.: LicData myLicData = new LicData(); 
        /// myLicData = (LicData) LoadObjectFromXML("C:\\MeinPfad\MeineDatei.xml", myLicData, typeof(LicData));
        /// </summary>
        /// <param name="path"></param>
        /// <param name="myObject"></param>
        /// <param name="myType"></param>
        /// <returns></returns>
        public static object LoadFromXML(this object Object, string path)
        {
            Type myType = Object.GetType();
            XmlSerializer mySerializer = new XmlSerializer(myType);
            if (!File.Exists(path))
                Object.SaveToXML(path);
            FileStream myFileStream = new FileStream(path, FileMode.Open);
            try
            {
                Object = mySerializer.Deserialize(myFileStream);
                myFileStream.Close();
            }
            catch (Exception ex)
            {
                slLogger.WriteLogLine(ex);
                Object = null;
                myFileStream.Close();
            }
            return Object;
        }


        public static void SaveToJson(this string ObjectToSave,string path)
        {
            string jsonString = JsonConvert.SerializeObject(ObjectToSave);
            File.WriteAllText(path, jsonString);
        }

        public static object LoadFromJson(string path)
        {
            string jsonString = File.ReadAllText(path);
            return JsonConvert.DeserializeObject(jsonString);
        }
        #endregion

        #region SpecialFolders

        /// <summary>
        /// Liefert den Firmennamen der ursprünglich aufrufenden Assembly
        /// </summary>
        public static string AssemblyCompany
        {
            get
            {
                // Alle Company-Attribute in dieser Assembly abrufen
                Assembly assembly;
                assembly = Assembly.GetEntryAssembly();
                if (assembly.IsNull())
                    assembly = Assembly.GetExecutingAssembly();
                object[] attributes = assembly.GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                // Eine leere Zeichenfolge zurückgeben, wenn keine Company-Attribute vorhanden sind
                if (attributes.Length == 0)
                    return "";
                // Den Wert des Company-Attributs zurückgeben, wenn eines vorhanden ist
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }

        /// <summary>
        /// Liefert den Installationsordner der ursprünglich aufrufenden Assembly
        /// </summary>
        /// <returns></returns>
        public static string GetExecutingFolder(bool UseExecutingAssembly = false)
        {
            Assembly assembly;
            if (UseExecutingAssembly)
                assembly = Assembly.GetExecutingAssembly();
            else
            {
                assembly = Assembly.GetEntryAssembly();
                if (assembly.IsNull())
                    assembly = Assembly.GetExecutingAssembly();
            }
            string aName = ((AssemblyName)assembly.GetName()).Name;
            string aPath = assembly.Location;
            string ret = aPath.Substring(0, (aPath.Length - aName.Length - 4));
            return ret;
        }

        /// <summary>
        /// Liefert den Datenordner der ursprünglich aufrufenden Assembly ohne abschliessenden \
        /// </summary>
        /// <returns></returns>
        public static string GetApplicationDataFolder(bool UseExecutingAssembly = false)
        {
            Assembly assembly;
            if (UseExecutingAssembly)
                assembly = Assembly.GetExecutingAssembly();
            else
            {
                assembly = Assembly.GetEntryAssembly();
                if (assembly.IsNull())
                    assembly = Assembly.GetExecutingAssembly();
            }
            string aName = ((AssemblyName)assembly.GetName()).Name;
            string aPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + aName;
            return aPath;
        }

        /// <summary>
        /// Liefert den Datenordner der ursprünglich aufrufenden EntryAssembly ohne abschliessenden \ mit dem Namen der Firma
        /// </summary>
        /// <returns></returns>
        public static string GetApplicationDataFolder(bool withCompanyName, bool UseExecutingAssembly = false)
        {
            Assembly assembly;
            if (UseExecutingAssembly)
                assembly = Assembly.GetExecutingAssembly();
            else
            {
                assembly = Assembly.GetEntryAssembly();
                if (assembly.IsNull())
                    assembly = Assembly.GetExecutingAssembly();
            }
            string aName = ((AssemblyName)assembly.GetName()).Name;
            string aPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                "\\" + AssemblyCompany + "\\" + aName;
            if (!Directory.Exists(aPath))
                Directory.CreateDirectory(aPath);
            return aPath;
        }

        /// <summary>
        /// Liefert den Datenordner der ursprünglich aufrufenden EntryAssembly ohne abschliessenden \ mit dem Namen der Firma
        /// </summary>
        /// <returns></returns>
        public static string GetCommonApplicationDataFolder(bool withCompanyName, string newSubfolder, bool UseExecutingAssembly = false)
        {
            Assembly assembly;
            if (UseExecutingAssembly)
                assembly = Assembly.GetExecutingAssembly();
            else
            {
                assembly = Assembly.GetEntryAssembly();
                if (assembly.IsNull())
                    assembly = Assembly.GetExecutingAssembly();
            }
            string aName = ((AssemblyName)assembly.GetName()).Name;
            string aPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) +
                "\\" + AssemblyCompany + "\\" + aName;
            if (!Directory.Exists(aPath + "\\" + newSubfolder))
                Directory.CreateDirectory(aPath + "\\" + newSubfolder);
            return aPath + "\\" + newSubfolder;
        }

        /// <summary>
        /// Liefert den Datenordner der ursprünglich aufrufenden EntryAssembly ohne abschliessenden \ mit dem Namen der Firma
        /// </summary>
        /// <returns></returns>
        public static string GetCommonApplicationDataFolder(bool withCompanyName, bool UseExecutingAssembly = false)
        {
            Assembly assembly;
            if (UseExecutingAssembly)
                assembly = Assembly.GetExecutingAssembly();
            else
            {
                assembly = Assembly.GetCallingAssembly();
                if (assembly.IsNull())
                    assembly = Assembly.GetExecutingAssembly();
            }
            string aName = ((AssemblyName)assembly.GetName()).Name;
            string aPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) +
                "\\" + AssemblyCompany + "\\" + aName;
            if (!Directory.Exists(aPath))
                Directory.CreateDirectory(aPath);
            return aPath;
        }

        /// <summary>
        /// Liefert den Dokumentenordner des aktuellen Benutzers (XP Eigene Dateien, Vista Dokumente)
        /// </summary>
        /// <returns></returns>
        public static string GetDocumentFolder()
        {
            string mp = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            return mp;
        }

        /// <summary>
        /// Liefert auf der Basis eines Environment.SpecialFolder einen Unterordner mit dem Pfad
        /// Firmenname\Programmname zurück. Existiert der Ordner nicht wird er erstellt.
        /// </summary>
        /// <param name="folder"></param>
        /// <returns></returns>
        public static string CreateProgEnvFolder(Environment.SpecialFolder folder)
        {
            string ProgDir = "";
            ProgDir = Environment.GetFolderPath(folder);
            AssemblyName progName = Assembly.GetEntryAssembly().GetName();
            ProgDir = ProgDir + "\\" + AssemblyCompany + "\\" + progName.Name;
            if (!Directory.Exists(ProgDir))
            {
                string TestDir = Environment.GetFolderPath(folder) + "\\" + AssemblyCompany;
                if (!Directory.Exists(TestDir))
                    Directory.CreateDirectory(TestDir);
                TestDir = TestDir + "\\" + progName.Name;
                if (!Directory.Exists(TestDir))
                    Directory.CreateDirectory(TestDir);
                ProgDir = TestDir;
            }
            return ProgDir;
        }


        #endregion
    }


    public class ExportField
    {
        public bool toExport { get; set; }
        public string FieldName { get; set; }
        public string FuncName { get; set; }
    }

    public class ExtensionHelper
    {
        public bool IsItemExport(string fieldName, List<ExportField> exportFields)
        {
            foreach (ExportField item in exportFields)
            {
                if (item.FieldName == fieldName)
                {
                    return item.toExport;
                }
            }
            return true;
        }

    }
}
