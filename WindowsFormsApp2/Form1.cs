using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = BieuThuc.Text;
            s = "(" + s;
            s += ")";
            tree root = build(s);
            trungto.Text = inorder(root);
            tiento.Text = preorder(root);
            hauto.Text = postorder(root);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        public class tree
        {
            public char data;
            public tree left, right;
        };

        // Hàm tạo node mới
        public static tree Node(char c)
        {
            tree n = new tree();
            n.data = c;
            n.left = n.right = null;
            return n;
        }

        // Hàm check xem phần tử có phải toán tử hoặc dấu ngoặc hay không 
        public static bool isOperator(char c)
        {
            if (c == '+' || c == '-' || c == '*' || c == '/' || c == '^' || c == '(' || c == ')') return true;
            return false;
        }

        public static bool isDigit(char c)
        {
            if (c >= '0' && c <= '9') return true;
            return false;
        }

        // Hàm tạo Cây biểu thức
        static tree build(String s)
        {

            // Stack chứa các toán hạng (node stack) mỗi phần tử của node stack sẽ là một node trên Cây biểu thức
            Stack<tree> stN = new Stack<tree>();

            // Stack chứa các toán tử hoặc dấu ngoặc "(" (char stack)
            Stack<char> stC = new Stack<char>();

            // Tạo node mới chứa toán tử
            tree N, NTren, NDuoi;

            // Đặt độ ưu tiên của các toán tử
            int[] p = new int[123];
            p['+'] = p['-'] = 1;
            p['/'] = p['*'] = 2;
            p['^'] = 3;
            p[')'] = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                {

                    // Push '(' vào char stack
                    stC.Push(s[i]);
                }

                // Push toán hạng vào node stack
                else if (isDigit(s[i]))
                {
                    N = Node(s[i]);
                    stN.Push(N);
                }
                else if (p[s[i]] > 0)
                {

                    // Nếu 1 toán tử có độ ưu tiên thấp hơn hoặc bằng các toán tử trong char stack
                    while (stC.Count != 0 && stC.Peek() != '('
                        && ((s[i] != '^' && p[stC.Peek()] >= p[s[i]])
                            || (s[i] == '^' && p[stC.Peek()] > p[s[i]])))
                    {

                        // Lấy toán tử ở đỉnh char stack và tạo ra 1 node mới cho cây biểu thức
                        // Xóa toán tử ở đỉnh char stack
                        N = Node(stC.Peek());
                        stC.Pop();

                        // Lấy phần tử ở đỉnh node stack và tạo ra 1 node mới cho cây biểu thức
                        // Xóa phần tử ở đỉnh node stack
                        NTren = stN.Peek();
                        stN.Pop();

                        // Lấy và xóa phần tử trên cùng kế tiếp từ node stack
                        NDuoi = stN.Peek();
                        stN.Pop();

                        // Cập nhật cây
                        N.left = NDuoi;
                        N.right = NTren;

                        // Push vào node stack
                        stN.Push(N);
                    }

                    // Push s[i] vào char stack
                    stC.Push(s[i]);
                }
                else if (s[i] == ')')
                {

                    while (stC.Count != 0 && stC.Peek() != '(')
                    {
                        // Tạo node mới t (node chứa toán tử)
                        // Con phải là node ở đỉnh node stack, con trái là nút ngay dưới đỉnh node stack
                        // Sau khi tạo xong, đưa t vào node stack

                        N = Node(stC.Peek());
                        stC.Pop();
                        NTren = stN.Peek();
                        stN.Pop();
                        NDuoi = stN.Peek();
                        stN.Pop();
                        N.left = NDuoi;
                        N.right = NTren;
                        stN.Push(N);
                    }
                    // xóa dấu ngoặc "(" ra khỏi char stack
                    stC.Pop();
                }
            }
            NTren = stN.Peek();
            return NTren;
        }

        // Hàm in ra post order traversal của cây
        static string postorder(tree root)
        {
            string result = "";
            if (root != null)
            {
                result += postorder(root.left).ToString() + postorder(root.right).ToString() + root.data.ToString();
                postorder(root.left);
                postorder(root.right);
                Console.Write(root.data);
            }
            return result;
        }

        // Hàm in ra pre order traversal của cây
        static string preorder(tree root)
        {
            string result = "";
            if (root != null)
            {
                result += root.data.ToString() + preorder(root.left).ToString() + preorder(root.right).ToString();
            }
            return result;
        }

        static string inorder(tree root)
        {
            string result = "";
            if (root != null)
            {
                result += inorder(root.left).ToString() + root.data.ToString() + inorder(root.right).ToString();
            }
            return result;
        }
    }
}
