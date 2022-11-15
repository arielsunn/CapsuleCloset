
namespace CapsuleCloset
{
    partial class frmWardrobe
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
            this.labelWardrobe = new System.Windows.Forms.Label();
            this.txtShirts = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShirts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelWardrobe
            // 
            this.labelWardrobe.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWardrobe.Location = new System.Drawing.Point(250, 50);
            this.labelWardrobe.Name = "labelWardrobe";
            this.labelWardrobe.Size = new System.Drawing.Size(300, 50);
            this.labelWardrobe.TabIndex = 0;
            this.labelWardrobe.Text = "Wardrobe";
            this.labelWardrobe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtShirts
            // 
            this.txtShirts.Location = new System.Drawing.Point(150, 175);
            this.txtShirts.Multiline = true;
            this.txtShirts.Name = "txtShirts";
            this.txtShirts.Size = new System.Drawing.Size(100, 250);
            this.txtShirts.TabIndex = 1;
            this.txtShirts.TextChanged += new System.EventHandler(this.txtShirts_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(150, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Shirts";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnShirts
            // 
            this.btnShirts.Location = new System.Drawing.Point(150, 450);
            this.btnShirts.Name = "btnShirts";
            this.btnShirts.Size = new System.Drawing.Size(100, 25);
            this.btnShirts.TabIndex = 4;
            this.btnShirts.Text = "Save Shirts";
            this.btnShirts.UseVisualStyleBackColor = true;
            this.btnShirts.Click += new System.EventHandler(this.btnShirts_Click);
            // 
            // frmWardrobe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnShirts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtShirts);
            this.Controls.Add(this.labelWardrobe);
            this.Name = "frmWardrobe";
            this.Text = "frmWardrobe";
            this.Load += new System.EventHandler(this.frmWardrobe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWardrobe;
        private System.Windows.Forms.TextBox txtShirts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShirts;
    }
}