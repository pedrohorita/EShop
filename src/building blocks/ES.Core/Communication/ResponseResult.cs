using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.Core.Communication
{
    public class ResponseResult
    {
        public ResponseResult()
        {
            Errors = new ResponseErrorMessages();
        }

        public string Title { get; set; }
        public int Status { get; set; }
        public ResponseErrorMessages Errors { get; set; }
    }
}
