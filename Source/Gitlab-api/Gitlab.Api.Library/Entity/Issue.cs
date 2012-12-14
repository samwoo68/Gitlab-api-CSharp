﻿
namespace Gitlab
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// 課題クラス
    /// </summary>
    public class Issue
    {
        public string Id { get; set; }
        public string Project_id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<string> Labels { get; set; }
        public string Milestone { get; set; }
        public string Assignee { get; set; }
        public Author Author { get; set; }
        public bool Closed { get; set; }
        public DateTime Updated_at { get; set; }
        public DateTime Created_at { get; set; }
    }
}
