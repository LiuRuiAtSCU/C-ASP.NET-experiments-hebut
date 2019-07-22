using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    //�������Բ
    public class Circle
    {
        public double radius;

        public Circle(double radius){
            this.radius=radius;
        }
    }

    //������������
    class Sphere : Circle
    {
        public Sphere(double radius):base(radius)
        {
        }

        //���������
        public double Square()
        {
            return 4 * Math.PI * radius * radius;
        }

        //���������
        public double Volume()
        {
            return 4/3 * Math.PI * radius * radius * radius;
        }

        //��ʾ����
        public void Show()
        {
            Console.WriteLine("�������Ϊ��{0}", Square());
            Console.WriteLine("���Ϊ��{0}", Volume());
        }
    }

    //����������Բ����
    public class Cylinder : Circle
    {
        public double height;

        public Cylinder(double height,double radius):base(radius)
        {
            this.height = height;
        }
        
        //���
        public double Square(){
            return 2 * Math.PI * radius * radius + 2 * Math.PI * radius * height;
        }

        //���
        public double Volume()
        {
            return Math.PI * radius * radius * height;
        }
        public void Show()
        {
            Console.WriteLine("Բ�������Ϊ��{0}", Square());
            Console.WriteLine("���Ϊ��{0}", Volume());
        }
    }

    //����һ��Բ׶��
    public class Cone : Circle
    {
        public double height;
      
        public Cone(double height,double radius):base(radius)
        {
            this.height = height;
        }

        //���
        public double Square()
        {
            return Math.PI * radius * height + Math.PI * radius * radius;
        }

        //���
        public double Volume()
        {
            return (1 / 3.0) * Math.PI * radius * radius * height;
        }

        public void Show()
        {
            Console.WriteLine("Բ׶���Ϊ��{0}", Square());
            Console.WriteLine("���Ϊ��{0}", Volume());
        }
    }
    public class Calculate{
        public static void Main(){

            Console.WriteLine("����������뾶��");
            try
            {
                double radious = Convert.ToDouble(Console.ReadLine());
                Sphere sphere=new Sphere(radious);
                sphere.Show();
            }
            catch (FormatException ex)
            {
                Console.WriteLine("����뾶��ʽ����!");
            }

            try
            {
                Console.WriteLine("������Բ����뾶���ߣ�");
                double radious = Convert.ToDouble(Console.ReadLine());
                double height = Convert.ToDouble(Console.ReadLine());
                Cylinder cylinder = new Cylinder(radious, height);
                cylinder.Show();
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Բ����뾶���߸�ʽ����!");
            }

            try
            {
                Console.WriteLine("������Բ׶��뾶���ߣ�");
                double radious = Convert.ToDouble(Console.ReadLine());
                double height = Convert.ToDouble(Console.ReadLine());
                Cone cone = new Cone(radious,height);
                cone.Show();
                Console.ReadLine();
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Բ׶��뾶���߸�ʽ����!");
                Console.ReadLine();
            }
        }
        
    }
}