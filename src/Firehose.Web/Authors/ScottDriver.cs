using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class SergeyVasin : IAmACommunityMember, IFilterMyBlogPosts
    {
        public string FirstName => "Scott";
        public string LastName => "Driver";
        public string ShortBioOrTagLine => "IT Pro, VMware user/lover, PowerShell the things, use bullet points";
        public string StateOrRegion => "Vermont, USA";
        public string EmailAddress => "Scott.driver42@gmail.com";
        public string TwitterHandle => "VTsnowboarder42";
        public string GravatarHash => "";
        public string GitHubHandle => "VTsnowboarder42";
        public GeoPosition Position => new GeoPosition(44.36670, -73.06577);
        public Uri WebSite => new Uri("https://virtualvt.wordpress.com");
        
        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://virtualvt.wordpress.com/feed/"); }
        }
        
        public bool Filter(SyndicationItem item)
        {
            return item.Categories.Any(c => c.Name.ToLowerInvariant().Equals("powershell"));
        }
    }
}
