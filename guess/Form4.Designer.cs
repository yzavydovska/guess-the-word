namespace guess
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bone = new System.Windows.Forms.PictureBox();
            this.fish = new System.Windows.Forms.PictureBox();
            this.carrot = new System.Windows.Forms.PictureBox();
            this.honey = new System.Windows.Forms.PictureBox();
            this.apple = new System.Windows.Forms.PictureBox();
            this.end = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carrot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.honey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apple)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(174, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(547, 71);
            this.label1.TabIndex = 0;
            this.label1.Text = "Who eats what?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Small", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Chocolate;
            this.label2.Location = new System.Drawing.Point(244, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(404, 49);
            this.label2.TabIndex = 1;
            this.label2.Text = "What does a _____ eat?";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // bone
            // 
            this.bone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bone.Image = ((System.Drawing.Image)(resources.GetObject("bone.Image")));
            this.bone.Location = new System.Drawing.Point(669, 142);
            this.bone.Name = "bone";
            this.bone.Size = new System.Drawing.Size(225, 247);
            this.bone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bone.TabIndex = 2;
            this.bone.TabStop = false;
            this.bone.Click += new System.EventHandler(this.bone_Click);
            // 
            // fish
            // 
            this.fish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fish.Image = ((System.Drawing.Image)(resources.GetObject("fish.Image")));
            this.fish.Location = new System.Drawing.Point(533, 362);
            this.fish.Name = "fish";
            this.fish.Size = new System.Drawing.Size(231, 145);
            this.fish.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fish.TabIndex = 3;
            this.fish.TabStop = false;
            this.fish.Click += new System.EventHandler(this.fish_Click);
            // 
            // carrot
            // 
            this.carrot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.carrot.Image = ((System.Drawing.Image)(resources.GetObject("carrot.Image")));
            this.carrot.Location = new System.Drawing.Point(343, 178);
            this.carrot.Name = "carrot";
            this.carrot.Size = new System.Drawing.Size(193, 178);
            this.carrot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.carrot.TabIndex = 4;
            this.carrot.TabStop = false;
            this.carrot.Click += new System.EventHandler(this.carrot_Click);
            // 
            // honey
            // 
            this.honey.Cursor = System.Windows.Forms.Cursors.Hand;
            this.honey.Image = ((System.Drawing.Image)(resources.GetObject("honey.Image")));
            this.honey.Location = new System.Drawing.Point(185, 362);
            this.honey.Name = "honey";
            this.honey.Size = new System.Drawing.Size(159, 151);
            this.honey.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.honey.TabIndex = 5;
            this.honey.TabStop = false;
            this.honey.Click += new System.EventHandler(this.honey_Click);
            // 
            // apple
            // 
            this.apple.Cursor = System.Windows.Forms.Cursors.Hand;
            this.apple.Image = ((System.Drawing.Image)(resources.GetObject("apple.Image")));
            this.apple.Location = new System.Drawing.Point(23, 178);
            this.apple.Name = "apple";
            this.apple.Size = new System.Drawing.Size(218, 172);
            this.apple.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.apple.TabIndex = 6;
            this.apple.TabStop = false;
            this.apple.UseWaitCursor = true;
            this.apple.Click += new System.EventHandler(this.apple_Click);
            // 
            // end
            // 
            this.end.BackColor = System.Drawing.Color.Peru;
            this.end.ForeColor = System.Drawing.Color.SeaShell;
            this.end.Location = new System.Drawing.Point(12, 486);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(116, 51);
            this.end.TabIndex = 7;
            this.end.Text = "END GAME";
            this.end.UseVisualStyleBackColor = false;
            this.end.Click += new System.EventHandler(this.end_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(895, 549);
            this.Controls.Add(this.end);
            this.Controls.Add(this.apple);
            this.Controls.Add(this.honey);
            this.Controls.Add(this.carrot);
            this.Controls.Add(this.fish);
            this.Controls.Add(this.bone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Eating";
            ((System.ComponentModel.ISupportInitialize)(this.bone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carrot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.honey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apple)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private PictureBox bone;
        private PictureBox fish;
        private PictureBox carrot;
        private PictureBox honey;
        private PictureBox apple;
        private Button end;
    }
}