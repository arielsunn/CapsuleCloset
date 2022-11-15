
namespace CapsuleCloset
{
    partial class frmHome
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
            this.labelCapsule = new System.Windows.Forms.Label();
            this.btnEditWardrobe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCapsule
            // 
            this.labelCapsule.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCapsule.Location = new System.Drawing.Point(250, 50);
            this.labelCapsule.Name = "labelCapsule";
            this.labelCapsule.Size = new System.Drawing.Size(300, 50);
            this.labelCapsule.TabIndex = 0;
            this.labelCapsule.Text = "Capsule Closet";
            this.labelCapsule.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEditWardrobe
            // 
            this.btnEditWardrobe.Location = new System.Drawing.Point(350, 500);
            this.btnEditWardrobe.Name = "btnEditWardrobe";
            this.btnEditWardrobe.Size = new System.Drawing.Size(100, 25);
            this.btnEditWardrobe.TabIndex = 1;
            this.btnEditWardrobe.Text = "Edit Wardrobe";
            this.btnEditWardrobe.UseVisualStyleBackColor = true;
            this.btnEditWardrobe.Click += new System.EventHandler(this.btnEditWardrobe_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnEditWardrobe);
            this.Controls.Add(this.labelCapsule);
            this.Name = "frmHome";
            this.Text = "Homepage";
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelCapsule;
        private System.Windows.Forms.Button btnEditWardrobe;
    }
}

