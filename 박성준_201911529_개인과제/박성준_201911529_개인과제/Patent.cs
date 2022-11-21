using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 박성준_201911529_개인과제
{
    internal class Patent
    {
        private string patentId;
        private string patentAbstrtCont;

        
      
        
            
        

        public Patent(string patentId)
        {
            this.patentId = patentId;
        }

        public string PatentAbstrtCont { get => patentAbstrtCont; set => patentAbstrtCont = value; }
    }
}
