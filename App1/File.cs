using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class File
    {
        private String title;
        private String detail;
        private DateTimeOffset date;
        public File(String title,String detail,DateTimeOffset date)
        {
            Title = title;
            Detail = detail;
            Date = date;
        }
        public String Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }
        public String Detail
        {
            get
            {
                return detail;
            }
            set
            {
                detail = value;
            }
        }
        public DateTimeOffset Date
        {
            get
            {
                return date;
            }
            set
            {
                date = value;
            }
        }
    }
}
