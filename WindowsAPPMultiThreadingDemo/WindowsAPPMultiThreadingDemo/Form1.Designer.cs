
namespace WindowsAPPMultiThreadingDemo
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
            this.btnTimeConsumingwork = new System.Windows.Forms.Button();
            this.btnPrintnumbers = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnTimeConsumingwork
            // 
            this.btnTimeConsumingwork.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnTimeConsumingwork.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimeConsumingwork.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnTimeConsumingwork.Location = new System.Drawing.Point(39, 27);
            this.btnTimeConsumingwork.Name = "btnTimeConsumingwork";
            this.btnTimeConsumingwork.Size = new System.Drawing.Size(440, 56);
            this.btnTimeConsumingwork.TabIndex = 0;
            this.btnTimeConsumingwork.Text = "Do some TimeConsumingWork";
            this.btnTimeConsumingwork.UseVisualStyleBackColor = false;
            this.btnTimeConsumingwork.Click += new System.EventHandler(this.btnTimeConsumingwork_Click);
            // 
            // btnPrintnumbers
            // 
            this.btnPrintnumbers.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnPrintnumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintnumbers.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPrintnumbers.Location = new System.Drawing.Point(39, 103);
            this.btnPrintnumbers.Name = "btnPrintnumbers";
            this.btnPrintnumbers.Size = new System.Drawing.Size(440, 56);
            this.btnPrintnumbers.TabIndex = 1;
            this.btnPrintnumbers.Text = "Print Numbers";
            this.btnPrintnumbers.UseVisualStyleBackColor = false;
            this.btnPrintnumbers.Click += new System.EventHandler(this.btnPrintnumbers_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(39, 176);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(455, 252);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 517);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnPrintnumbers);
            this.Controls.Add(this.btnTimeConsumingwork);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTimeConsumingwork;
        private System.Windows.Forms.Button btnPrintnumbers;
        private System.Windows.Forms.ListView listView1;
    }
}

