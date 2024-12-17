namespace OOPW2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ข้อความตัวอักษร
            string inputNum1 = num1.Text;
            string inputNum2 = num2.Text;
            // convert str to double 
            // double /  flout  = ใส่ค่าเลขตัวแปรเป็นทศนิยม
            // int / integer = ใส่ค่าตัวเลขเป็นจำนวนเต็ม
            double iNum1 = Double.Parse(inputNum1);
            double iNum2 = Double.Parse(inputNum2);
            // 
            // double ààÅÐ flout ·È¹ÔÂÁ
            double iResult = iNum1 + iNum2; // function + - * /
            // ที่ตัวแปรชื่อ result
            // มีคุณสมบัติชื่อ Text
            Result.Text = iResult.ToString();  // .ToString() แปรค่าเป็น str
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // ข้อความตัวอักษร
            string inputNum1 = num1.Text;
            string inputNum2 = num2.Text;
            // convert str to double 
            // double /  flout  = ใส่ค่าเลขตัวแปรเป็นทศนิยม
            // int / integer = ใส่ค่าตัวเลขเป็นจำนวนเต็ม
            double iNum1 = Double.Parse(inputNum1);
            double iNum2 = Double.Parse(inputNum2);
            double iResult = iNum1 - iNum2; // function + - * /
            Result.Text = iResult.ToString(); // .ToString() แปรค่าเป็น str
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // ข้อความตัวอักษร
            string inputNum1 = num1.Text;
            string inputNum2 = num2.Text;
            // convert str to double 
            // double /  flout  = ใส่ค่าเลขตัวแปรเป็นทศนิยม
            // int / integer = ใส่ค่าตัวเลขเป็นจำนวนเต็ม
            double iNum1 = Double.Parse(inputNum1);
            double iNum2 = Double.Parse(inputNum2);
            double iResult = iNum1 * iNum2; // function + - * /
            Result.Text = iResult.ToString(); // .ToString() แปรค่าเป็น str
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // ข้อความตัวอักษร
            string inputNum1 = num1.Text;
            string inputNum2 = num2.Text;
            // convert str to double 
            // double /  flout  = ใส่ค่าเลขตัวแปรเป็นทศนิยม
            // int / integer = ใส่ค่าตัวเลขเป็นจำนวนเต็ม
            double iNum1 = Double.Parse(inputNum1);
            double iNum2 = Double.Parse(inputNum2);
            double iResult = iNum1 / iNum2; // function + - * /
            Result.Text = iResult.ToString(); // .ToString() = แปรค่าเป็น str
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // ล้างช่องให้ว่างTextBox
            num1.Text = "";
            num2.Text = "";
            Result.Text = "";
        }

        private void Result_TextChanged(object sender, EventArgs e)
        {

        }
    }
}