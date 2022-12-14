namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BieuThuc = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tiento = new System.Windows.Forms.TextBox();
            this.trungto = new System.Windows.Forms.TextBox();
            this.hauto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BieuThuc
            // 
            this.BieuThuc.Font = new System.Drawing.Font("Cascadia Code SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BieuThuc.Location = new System.Drawing.Point(22, 42);
            this.BieuThuc.Name = "BieuThuc";
            this.BieuThuc.Size = new System.Drawing.Size(755, 34);
            this.BieuThuc.TabIndex = 0;
            this.BieuThuc.Text = "(5+7)*3-4/2";
            this.BieuThuc.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LavenderBlush;
            this.button1.Font = new System.Drawing.Font("Cascadia Code SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(22, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(755, 43);
            this.button1.TabIndex = 1;
            this.button1.Text = "START";
            this.button1.UseCompatibleTextRendering = true;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Dạng trung tố:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "Dạng hậu tố:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Code SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 30);
            this.label3.TabIndex = 7;
            this.label3.Text = "Dạng tiền tố:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Code SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(325, 30);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nhập biểu thức toán học:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tiento
            // 
            this.tiento.Font = new System.Drawing.Font("Cascadia Code SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tiento.Location = new System.Drawing.Point(22, 296);
            this.tiento.Name = "tiento";
            this.tiento.Size = new System.Drawing.Size(755, 34);
            this.tiento.TabIndex = 13;
            // 
            // trungto
            // 
            this.trungto.Font = new System.Drawing.Font("Cascadia Code SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trungto.Location = new System.Drawing.Point(22, 199);
            this.trungto.Name = "trungto";
            this.trungto.Size = new System.Drawing.Size(755, 34);
            this.trungto.TabIndex = 14;
            // 
            // hauto
            // 
            this.hauto.Font = new System.Drawing.Font("Cascadia Code SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hauto.Location = new System.Drawing.Point(22, 393);
            this.hauto.Name = "hauto";
            this.hauto.Size = new System.Drawing.Size(755, 34);
            this.hauto.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hauto);
            this.Controls.Add(this.trungto);
            this.Controls.Add(this.tiento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BieuThuc);
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "Đồ Án Expression Tree";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BieuThuc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tiento;
        private System.Windows.Forms.TextBox trungto;
        private System.Windows.Forms.TextBox hauto;
    }
}

