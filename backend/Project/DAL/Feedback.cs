//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Feedback
    {
        public long Id { get; set; }
        public string IP_Address { get; set; }
        public long VideoId { get; set; }
        public long PauseCount { get; set; }
        public long BackCount { get; set; }
        public int Stars { get; set; }
        public long Finish { get; set; }
        public long MinutesStopped { get; set; }
    
        public virtual Senior Senior { get; set; }
        public virtual Video Video { get; set; }
    }
}
