﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;

namespace SimpleBlog.Models
{
    public class Tag
    {
        public virtual int Id { get; set; }
        public virtual string Slug { get; set; } // specialize title to use with url
        public virtual string Name { get; set; }

        public virtual IList<Post> Posts { get; set; } 
    }

    public class TagMap : ClassMapping<Tag>
    {
        public TagMap()
        {
            Table("tags");

            Id(x => x.Id, x => x.Generator(Generators.Identity));

            Property(x => x.Name, x => x.NotNullable(true));
            Property(x => x.Slug, x => x.NotNullable(true));

            // link IList tags to our posts
            Bag(x => x.Posts, x =>
            {
                x.Key(y => y.Column("tag_id"));
                x.Table("post_tags");

            }, x => x.ManyToMany(y => y.Column("post_id")));
        }
    }
}