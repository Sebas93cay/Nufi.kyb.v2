namespace Nufi.kyb.v2.Models
{
	public class RUGRequest
	{
        public int code { get; set; }
        public string status { get; set; }
        public string message { get; set; }
        public RUGData[] data { get; set; }
	}
}
