
namespace LifDBMS
{
    partial class FormDashboard
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
            this.pContainer1 = new System.Windows.Forms.Panel();
            this.dashboardBtn = new System.Windows.Forms.Button();
            this.projectBtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pContainer2 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pContainer1
            // 
            this.pContainer1.Location = new System.Drawing.Point(159, 11);
            this.pContainer1.Name = "pContainer1";
            this.pContainer1.Size = new System.Drawing.Size(1764, 717);
            this.pContainer1.TabIndex = 0;
            // 
            // dashboardBtn
            // 
            this.dashboardBtn.Location = new System.Drawing.Point(12, 192);
            this.dashboardBtn.Name = "dashboardBtn";
            this.dashboardBtn.Size = new System.Drawing.Size(128, 23);
            this.dashboardBtn.TabIndex = 1;
            this.dashboardBtn.Text = "Dashboard";
            this.dashboardBtn.UseVisualStyleBackColor = true;
            // 
            // projectBtn
            // 
            this.projectBtn.Location = new System.Drawing.Point(12, 221);
            this.projectBtn.Name = "projectBtn";
            this.projectBtn.Size = new System.Drawing.Size(128, 23);
            this.projectBtn.TabIndex = 2;
            this.projectBtn.Text = "Projects";
            this.projectBtn.UseVisualStyleBackColor = true;
            this.projectBtn.Click += new System.EventHandler(this.projectBtn_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 250);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Meetings";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 279);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(128, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Proposals";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 308);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(128, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "Agreements";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.pContainer1);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.dashboardBtn);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.projectBtn);
            this.groupBox1.Location = new System.Drawing.Point(0, -11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(153, 555);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // pContainer2
            // 
            this.pContainer2.Location = new System.Drawing.Point(159, 0);
            this.pContainer2.Name = "pContainer2";
            this.pContainer2.Size = new System.Drawing.Size(1764, 717);
            this.pContainer2.TabIndex = 7;
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 720);
            this.Controls.Add(this.pContainer2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDashboard";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pContainer1;
        private System.Windows.Forms.Button dashboardBtn;
        private System.Windows.Forms.Button projectBtn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel pContainer2;
    }
}