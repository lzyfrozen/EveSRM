using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EveSRM
{
    public class HozonResult
    {
        public string batchNum { get; set; }
        public string responseStatus { get; set; }
        public string responseMessage { get; set; }
        public string executeResult { get; set; }

        public List<restResponseDtlDTO> restResponseDtlDTOList { get; set; } = new List<restResponseDtlDTO>();
    }

    public class restResponseDtlDTO
    {
        public string documentId { get; set; }
        public string documentCode { get; set; }
        public string responseStatus { get; set; }
        public string responseMessage { get; set; }
        public string keyword1 { get; set; }
        public string keyword2 { get; set; }
        public string keyword3 { get; set; }
        public string keyword4 { get; set; }
        public string keyword5 { get; set; }
        public string result { get; set; }
    }
}
