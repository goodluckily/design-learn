using System;

namespace SingletonPattern
{
    /// <summary>
    /// ����һ��������
    /// </summary>
    public class WeatherForecast
    {
        // ����һ����̬�������������Ψһʵ��
        private static WeatherForecast uniqueInstance;
        // ����һ��������ֹ���߳�
        private static readonly object locker = new object();

        // ����˽�й��캯����ʹ��粻�ܴ�������ʵ��
        private WeatherForecast()
        {
            Date = DateTime.Now;
        }
        /// <summary>
        /// ��̬������������Ψһʵ��
        /// ������ڣ��򷵻�
        /// </summary>
        /// <returns></returns>
        public static WeatherForecast GetInstance()
        {
            // ����һ���߳�ִ�е�ʱ�򣬻��locker���� "����"��
            // �������߳�ִ�е�ʱ�򣬻�ȴ� locker ִ�������
            if (uniqueInstance == null)
            {
                lock (locker)
                {
                    // ������ʵ���������򴴽�������ֱ�ӷ���
                    if (uniqueInstance == null)
                    {
                        uniqueInstance = new WeatherForecast();
                    }
                }
            }

            return uniqueInstance;
        }
        public DateTime Date { get; set; }
        public int TemperatureC { get; set; }
        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
        public string Summary { get; set; }
    }
}
