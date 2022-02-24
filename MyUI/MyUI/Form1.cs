using MyLiberary;

namespace MyUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //create object from MyMath Class
            MyMath myMath = new MyMath();
            int sum1 = myMath.getSummatiom(1,2);
            int sum2 = myMath.getSummation(2, 3, 4);

            this.textBox1.Text = sum1.ToString();

            string grade = MyGPA.calculateGrade(80.0);
            this.textBox2.Text = sum2.ToString();
            //การเติม .Text ลงท้ายหมายความว่า จะแสดงข้อมูลเป็นtext.
        }
    }
}