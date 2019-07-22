using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionTest
{
    public class Meteorologist
    {
        public int[] rainfall = new int [12];
        public int[] pollution = new int [12];

        //�����вι��캯��
        public Meteorologist(int[] rainfall,int[] pollution)
        {
            try
            {
                for (int i = 0; i < 12; i++)
                {
                    this.rainfall[i] = rainfall[i];
                    this.pollution[i] = pollution[i];
                }
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Meteorologist���캯�������鷢��Խ�磡");
            }
            catch (FormatException e)
            {
                Console.WriteLine("�·ݸ�ʽ����ȷ!");
            }
        }

        //��������Ԫ��
        public int GetRainFall(int index)
        {
            try
            {
                return rainfall[index];
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("GetRainFall���������鷢��Խ�磡");
                return -1;
            }
            catch (FormatException e)
            {
                Console.WriteLine("��Ⱦ���ʽ����ȷ��");
                return -1;
            }
        }

        //���㽵��������Ⱦ��ĺ���
        public int GetAveragePollution(int index)
        {
            try
            {
                return pollution[index] / rainfall[index];
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("GetAveragePollution���������鷢��Խ�磡");
                return -1;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("GetAveragePollution�����г���Ϊ0��");
                return -1;
            }
        }

    }
    public class Test
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("������rainfall�������ֵ���Կո�����");
                string[] rainfallStr=Console.ReadLine().Split(' ');
                int[] rainfall = new int[rainfallStr.Length];
                for (int i = 0; i < rainfallStr.Length; i++)
                {
                    rainfall[i] = Convert.ToInt32(rainfallStr[i]);
                }

                Console.WriteLine("������pollution�������ֵ���Կո�����");
                string[] pollutionStr = Console.ReadLine().Split(' ');
                int[] pollution = new int[pollutionStr.Length];
                for (int i = 0; i < pollutionStr.Length; i++)
                {
                    pollution[i] = Convert.ToInt32(pollutionStr[i]);
                }

                Meteorologist test = new Meteorologist(rainfall,pollution);

                Console.WriteLine();
                //��ʾ����
                for (int i = 0; i < rainfall.Length; i++)
                {
                    Console.WriteLine("{0}�½�����Ϊ{1}", i + 1, rainfall[i]);
                    
                }
                
                Console.WriteLine("����������鿴���·�:");
                int index = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("{0}�µ�λ�������е���Ⱦ�ﺬ��Ϊ��{1}", index, test.GetAveragePollution(index - 1));
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine("�������и�ʽת������");
            }
            catch (FormatException e)
            {
                Console.WriteLine("���ݸ�ʽ����");
            }
        }
    }
}