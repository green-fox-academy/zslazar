using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using URLShortener.Entities;
using URLShortener.Models;

namespace URLShortener.Repositories
{
    public class UrlRepository
    {
        private UrlContext urlContext;

        public UrlRepository(UrlContext urlContext)
        {
            this.urlContext = urlContext;
        }

        public List<Url> GetUrls()
        {
            return urlContext.Urls.ToList();
        }

        public void AddNewUrl(Url longUrl)
        {
            urlContext.Urls.Add(longUrl);
            urlContext.SaveChanges();
        }

        //check if the submitted url contains the protocol (http or https)
        public string CheckHttps(string url)
        {
            if (!url.Contains("https"))
            {
                string https = "https";
                url = string.Concat(https, url);
                return url;
            }
            return url;
        }

        //check if url already shortened
        public bool CheckIfLongExsistInDb(Url longUrl)
        {
            return urlContext.Urls.Contains(longUrl);
        }

        public List<Url> SearchLongUrl(string longUrl)
        {
            return urlContext.Urls.Where(u => u.LongUrl.Equals(longUrl)).ToList();
        }

        //generate a 6 character long random string /save page
        public string Randomizer(string url)
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789abcdefghijklmnopqrstuvwxyz";

            return new string(Enumerable.Repeat(chars, 6)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        //should have an endpoint /shorten which accepts a url parameter, eg. /shorten/r4nd0m
        //searches for the url parameter in the database to get the original url
        //redirects to the original url
        //redirects to the index page if not found

        //public string SearchShortUrl(Url shortUrl)
        //{
        //    return urlContext.Urls.Where(u => u.ShortUrl.Equals(shortUrl)).ToString();
        //}

        public List<Url> SearchShortUrl(string shortUrl)
        {
            //var shortie = urlContext.Urls.FirstOrDefault(s => s.ShortUrl == shortUrl).ToString();
                        
            return urlContext.Urls.Where(u => u.ShortUrl.Equals(shortUrl)).ToList();
        }
    }
}
