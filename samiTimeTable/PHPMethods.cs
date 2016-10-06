using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace samiTimeTable
{
    class PHPMethods
    {
        public static string LECTURES = "Lectures";
        public static string PRACTICAL = "PracticalSessions";
        public static string url = "http://wolfsthal.esy.es/SceTime/";

        public static string HttpInsert(string pageSuffix,
            string[] paramName, string[] paramVal)
        {
            try {
                string page = url + pageSuffix;
                HttpWebRequest req = WebRequest.Create(new Uri(page))
                                     as HttpWebRequest;
                req.Method = "POST";
                
                req.ContentType = "application/x-www-form-urlencoded";

                // Build a string with all the params, properly encoded.
                // We assume that the arrays paramName and paramVal are
                // of equal length:
                StringBuilder paramz = new StringBuilder();
                for (int i = 0; i < paramName.Length; i++)
                {
                    paramz.Append(paramName[i]);
                    paramz.Append("=");
                    paramz.Append(System.Web.HttpUtility.UrlEncode(paramVal[i]));
                    if (i < paramName.Length - 1)
                        paramz.Append("&");
                }

                // Encode the parameters as form data:
                byte[] formData =
                    UTF8Encoding.UTF8.GetBytes(paramz.ToString());
                req.ContentLength = formData.Length;

                // Send the request:
                using (Stream post = req.GetRequestStream())
                {
                    post.Write(formData, 0, formData.Length);
                }

                // Pick up the response:
                string result = null;
                using (HttpWebResponse resp = req.GetResponse()
                                              as HttpWebResponse)
                {
                    StreamReader reader =
                        new StreamReader(resp.GetResponseStream());
                    result = reader.ReadToEnd();
                }

                return result;
            }
            catch (WebException e)
            {
                Console.WriteLine("This program is expected to throw WebException on successful run." +
                                    "\n\nException Message :" + e.Message);
                if (e.Status == WebExceptionStatus.ProtocolError)
                {
                    Console.WriteLine("Status Code : {0}", ((HttpWebResponse)e.Response).StatusCode);
                    Console.WriteLine("Status Description : {0}", ((HttpWebResponse)e.Response).StatusDescription);
                }
                return "Error: שגיאת רשת";
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return "Error: שגיאת רשת";
            }
        }

        public static string HttpSelect(string pageSuffix,
           string key, string value, string type)
        {
            string page = url + pageSuffix;
            try {
                HttpWebRequest req = WebRequest.Create(new Uri(page))
                                     as HttpWebRequest;
                req.Method = "POST";
                req.ContentType = "application/x-www-form-urlencoded";

                // Build a string with all the params, properly encoded.
                // We assume that the arrays paramName and paramVal are
                // of equal length:
                StringBuilder paramz = new StringBuilder();
                paramz.Append("key=" + key + "&");
                paramz.Append("value=" + value + "&");
                paramz.Append("type=" + type);

                // Encode the parameters as form data:
                byte[] formData =
                    UTF8Encoding.UTF8.GetBytes(paramz.ToString());
                req.ContentLength = formData.Length;

                // Send the request:
                using (Stream post = req.GetRequestStream())
                {
                    post.Write(formData, 0, formData.Length);
                }

                // Pick up the response:
                string result = null;
                //gives http errors. should catch somehow.
                using (HttpWebResponse resp = req.GetResponse()
                                              as HttpWebResponse)
                {
                    StreamReader reader =
                        new StreamReader(resp.GetResponseStream());
                    result = reader.ReadToEnd();
                }

                return result;
            }
            catch (WebException e)
            {
                Console.WriteLine("This program is expected to throw WebException on successful run." +
                                    "\n\nException Message :" + e.Message);
                if (e.Status == WebExceptionStatus.ProtocolError)
                {
                    Console.WriteLine("Status Code : {0}", ((HttpWebResponse)e.Response).StatusCode);
                    Console.WriteLine("Status Description : {0}", ((HttpWebResponse)e.Response).StatusDescription);
                }
                return "Error: שגיאת רשת";
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return "Error: שגיאת רשת";
            }
        }

        public static string HttpSearchAs(string key)
        {
            string page = url + "range.php";
            try {
                HttpWebRequest req = WebRequest.Create(new Uri(page))
                                     as HttpWebRequest;

                req.Method = "POST";
                req.ContentType = "application/x-www-form-urlencoded";

                // Build a string with all the params, properly encoded.
                // We assume that the arrays paramName and paramVal are
                // of equal length:
                StringBuilder paramz = new StringBuilder();
                paramz.Append("key=" + key);

                // Encode the parameters as form data:
                byte[] formData =
                    UTF8Encoding.UTF8.GetBytes(paramz.ToString());
                req.ContentLength = formData.Length;

                // Send the request:
                using (Stream post = req.GetRequestStream())
                {
                    post.Write(formData, 0, formData.Length);
                }

                // Pick up the response:
                string result = null;
                using (HttpWebResponse resp = req.GetResponse()
                                              as HttpWebResponse)
                {
                    StreamReader reader =
                        new StreamReader(resp.GetResponseStream());
                    result = reader.ReadToEnd();
                }
                return result;
            }
            catch (WebException e)
            {
                Console.WriteLine("This program is expected to throw WebException on successful run." +
                                    "\n\nException Message :" + e.Message);
                if (e.Status == WebExceptionStatus.ProtocolError)
                {
                    Console.WriteLine("Status Code : {0}", ((HttpWebResponse)e.Response).StatusCode);
                    Console.WriteLine("Status Description : {0}", ((HttpWebResponse)e.Response).StatusDescription);
                }
                return "Error: שגיאת רשת";
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return "Error: שגיאת רשת";
            }

        }
        public static string HttpVerify(string email, string password)
        {
            string page = url + "verify.php";
            try {
                HttpWebRequest req = WebRequest.Create(new Uri(page))
                                     as HttpWebRequest;
                req.Method = "POST";
                req.ContentType = "application/x-www-form-urlencoded";

                // Build a string with all the params, properly encoded.
                // We assume that the arrays paramName and paramVal are
                // of equal length:
                StringBuilder paramz = new StringBuilder();
                paramz.Append("email=" + email);
                paramz.Append("&");
                paramz.Append("password=" + password);

                // Encode the parameters as form data:
                byte[] formData =
                    UTF8Encoding.UTF8.GetBytes(paramz.ToString());
                req.ContentLength = formData.Length;

                // Send the request:
                using (Stream post = req.GetRequestStream())
                {
                    post.Write(formData, 0, formData.Length);
                }

                // Pick up the response:
                string result = null;
                using (HttpWebResponse resp = req.GetResponse()
                                              as HttpWebResponse)
                {
                    StreamReader reader =
                        new StreamReader(resp.GetResponseStream());
                    result = reader.ReadToEnd();
                }

                return result;
            }
            catch (WebException e)
            {
                Console.WriteLine("This program is expected to throw WebException on successful run." +
                                    "\n\nException Message :" + e.Message);
                if (e.Status == WebExceptionStatus.ProtocolError)
                {
                    Console.WriteLine("Status Code : {0}", ((HttpWebResponse)e.Response).StatusCode);
                    Console.WriteLine("Status Description : {0}", ((HttpWebResponse)e.Response).StatusDescription);
                }
                return "Error: שגיאת רשת";
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return "Error: שגיאת רשת";
            }
        }
        public static string HttpDelete(string pageSuffix, string deleteIDs)
        {
            string page = url + pageSuffix;
            try {
                HttpWebRequest req = WebRequest.Create(new Uri(page))
                                     as HttpWebRequest;
                req.Method = "POST";
                req.ContentType = "application/x-www-form-urlencoded";

                // Build a string with all the params, properly encoded.
                // We assume that the arrays paramName and paramVal are
                // of equal length:
                StringBuilder paramz = new StringBuilder();
                paramz.Append("id=" + System.Web.HttpUtility.UrlEncode(deleteIDs));

                // Encode the parameters as form data:
                byte[] formData =
                    UTF8Encoding.UTF8.GetBytes(paramz.ToString());
                req.ContentLength = formData.Length;

                // Send the request:
                using (Stream post = req.GetRequestStream())
                {
                    post.Write(formData, 0, formData.Length);
                }

                // Pick up the response:
                string result = null;
                using (HttpWebResponse resp = req.GetResponse()
                                              as HttpWebResponse)
                {
                    StreamReader reader =
                        new StreamReader(resp.GetResponseStream());
                    result = reader.ReadToEnd();
                }
                return result;
            }
            catch (WebException e)
            {
                Console.WriteLine("This program is expected to throw WebException on successful run." +
                                    "\n\nException Message :" + e.Message);
                if (e.Status == WebExceptionStatus.ProtocolError)
                {
                    Console.WriteLine("Status Code : {0}", ((HttpWebResponse)e.Response).StatusCode);
                    Console.WriteLine("Status Description : {0}", ((HttpWebResponse)e.Response).StatusDescription);
                }
                return "Error: שגיאת רשת";
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return "Error: שגיאת רשת";
            }
        }


    }
}
