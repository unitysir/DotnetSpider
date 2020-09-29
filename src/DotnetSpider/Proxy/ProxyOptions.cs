namespace DotnetSpider.Proxy
{
	public class ProxyOptions
	{
		/// <summary>
		/// 测试代理是否正常的链接
		/// </summary>
		public string ProxyTestUrl { get; set; } = "http://www.baidu.com";

		/// <summary>
		/// 代理供应 API
		/// 一般代理供应商都会提供 API 请求返回可用的代理列表
		/// </summary>
		public string ProxySupplierUrl { get; set; }

		/// <summary>
		/// 是否使用代理
		/// </summary>
		public bool UseProxy { get; set; }
	}
}