using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HRVWeatherControl_ZZGA
{
    /// <summary>
    /// 今日天气控件
    /// </summary>
    public class TdWeather
    {
        private string weather;
        private string temperature;
        private string wind;
        private string airQual;

        /// <summary>
        /// 默认构造函数
        /// </summary>
        public TdWeather()
        {
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="weather"></param>
        /// <param name="temperature"></param>
        /// <param name="wind"></param>
        /// <param name="airQual"></param>
        public TdWeather(string weather, string temperature, string wind, string airQual)
        {
            this.weather = weather;
            this.temperature = temperature;
            this.wind = wind;
            this.airQual = airQual;
        }

        /// <summary>
        /// 天气状况：晴天、雨天、雷阵雨、阴天、多云
        /// </summary>
        public string Weather { get => weather; set => weather = value; }
        /// <summary>
        /// 气温
        /// </summary>
        public string Temperature { get => temperature; set => temperature = value; }
        /// <summary>
        /// 风力
        /// </summary>
        public string Wind { get => wind; set => wind = value; }
        /// <summary>
        /// 空气质量
        /// </summary>
        public string AirQual { get => airQual; set => airQual = value; }
    }
}
