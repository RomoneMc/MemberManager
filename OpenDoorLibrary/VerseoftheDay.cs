using System;
using System.Net;

namespace OpenDoorLibrary
{
    public static class VerseoftheDay
    {
        static string Verse;

        public static string GetVerseoftheDay()
        {
            try
            {
                WebRequest request = WebRequest.Create("http://www.ourmanna.com/verses/api/get/?format=text");
                WebResponse response = request.GetResponse();
                System.IO.StreamReader reader = new System.IO.StreamReader(response.GetResponseStream());
                Verse = reader.ReadToEnd();
            }
            catch
            {
                Verse = string.Empty;
            }

            return Verse;
        }
    }
}