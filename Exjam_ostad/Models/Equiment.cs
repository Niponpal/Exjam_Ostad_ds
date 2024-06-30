using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exjam_ostad.Models
{
    public class Equiment:Member
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Count { get; set; }
        public DateTime DateTime { get; set; }

        public static List<Equiment> ListEquiment()
        {
            List<Equiment> list = new List<Equiment>();
            for(int i = 1;i<=20;i++) {
                Equiment equiment= new Equiment();
                equiment.Id = i;
                equiment.Name ="Lapton" +i.ToString();
                equiment.Count = i.ToString();
                equiment.DateTime = DateTime.Now;

                equiment.MemberName = "Nipon";
                equiment.MobileNumber ="0445787897";
                equiment.MemberDesignation = "Teacher";
                list.Add(equiment);    
            }
            return list;


        }
    }
}
