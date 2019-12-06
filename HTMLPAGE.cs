using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CMSWebsite
{
    public class HTMLPAGE
    {
        // a page contains these
        private string pageid;
        private string pagetitle;
        private string pagebody;
        private string ispublished;
        public string PageId
        {
            get { return pageid; }
            set { pageid = value; }
        }
        public string PageTitle
        {
            get { return pagetitle; }
            set { pagetitle = value; }
        }
        public string PageBody
        {
            get { return pagebody; }
            set { pagebody = value; }
        }
        public string IsPublished
        {
            get { return ispublished; }
            set { ispublished = value; }
        }


    }
}