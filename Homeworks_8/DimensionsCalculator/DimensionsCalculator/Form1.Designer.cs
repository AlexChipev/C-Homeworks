namespace DimensionsCalculator
{
    partial class DropDown
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DropDown));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.length = new System.Windows.Forms.Label();
            this.wide = new System.Windows.Forms.Label();
            this.heght = new System.Windows.Forms.Label();
            this.textLength = new System.Windows.Forms.TextBox();
            this.textWide = new System.Windows.Forms.TextBox();
            this.textHeight = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.Label();
            this.count = new System.Windows.Forms.Label();
            this.textQuantity = new System.Windows.Forms.TextBox();
            this.textResult = new System.Windows.Forms.TextBox();
            this.buttonResult = new System.Windows.Forms.Button();
            this.checkMeters = new System.Windows.Forms.CheckBox();
            this.checkCub = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(661, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "Choose:";
            // 
            // length
            // 
            this.length.AutoSize = true;
            this.length.Location = new System.Drawing.Point(52, 77);
            this.length.Name = "length";
            this.length.Size = new System.Drawing.Size(52, 13);
            this.length.TabIndex = 3;
            this.length.Text = "дължина";
            // 
            // wide
            // 
            this.wide.AutoSize = true;
            this.wide.Location = new System.Drawing.Point(52, 116);
            this.wide.Name = "wide";
            this.wide.Size = new System.Drawing.Size(45, 13);
            this.wide.TabIndex = 4;
            this.wide.Text = "ширина";
            // 
            // heght
            // 
            this.heght.AutoSize = true;
            this.heght.Location = new System.Drawing.Point(52, 156);
            this.heght.Name = "heght";
            this.heght.Size = new System.Drawing.Size(54, 13);
            this.heght.TabIndex = 5;
            this.heght.Text = "височина";
            // 
            // textLength
            // 
            this.textLength.AcceptsTab = true;
            this.textLength.Location = new System.Drawing.Point(130, 74);
            this.textLength.Name = "textLength";
            this.textLength.Size = new System.Drawing.Size(63, 20);
            this.textLength.TabIndex = 6;
            // 
            // textWide
            // 
            this.textWide.AcceptsTab = true;
            this.textWide.Location = new System.Drawing.Point(130, 113);
            this.textWide.Name = "textWide";
            this.textWide.Size = new System.Drawing.Size(63, 20);
            this.textWide.TabIndex = 7;
            // 
            // textHeight
            // 
            this.textHeight.AcceptsTab = true;
            this.textHeight.Location = new System.Drawing.Point(130, 153);
            this.textHeight.Name = "textHeight";
            this.textHeight.Size = new System.Drawing.Size(63, 20);
            this.textHeight.TabIndex = 8;
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(251, 86);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(55, 13);
            this.result.TabIndex = 9;
            this.result.Text = "резултат:";
            // 
            // count
            // 
            this.count.AutoSize = true;
            this.count.BackColor = System.Drawing.Color.Transparent;
            this.count.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.count.Location = new System.Drawing.Point(66, 43);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(31, 13);
            this.count.TabIndex = 10;
            this.count.Text = "брой";
            // 
            // textQuantity
            // 
            this.textQuantity.AcceptsTab = true;
            this.textQuantity.Location = new System.Drawing.Point(130, 40);
            this.textQuantity.Name = "textQuantity";
            this.textQuantity.Size = new System.Drawing.Size(40, 20);
            this.textQuantity.TabIndex = 11;
            this.textQuantity.Text = "1";
            // 
            // textResult
            // 
            this.textResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textResult.Location = new System.Drawing.Point(312, 78);
            this.textResult.Name = "textResult";
            this.textResult.Size = new System.Drawing.Size(48, 22);
            this.textResult.TabIndex = 12;
            // 
            // buttonResult
            // 
            this.buttonResult.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttonResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonResult.Location = new System.Drawing.Point(95, 202);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(89, 34);
            this.buttonResult.TabIndex = 13;
            this.buttonResult.Text = "Изчисли";
            this.buttonResult.UseVisualStyleBackColor = false;
            this.buttonResult.Click += new System.EventHandler(this.buttonResult_Click);
            // 
            // checkMeters
            // 
            this.checkMeters.AutoSize = true;
            this.checkMeters.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkMeters.Location = new System.Drawing.Point(105, 4);
            this.checkMeters.Name = "checkMeters";
            this.checkMeters.Size = new System.Drawing.Size(65, 17);
            this.checkMeters.TabIndex = 14;
            this.checkMeters.Text = "т.метри";
            this.checkMeters.UseVisualStyleBackColor = false;
            // 
            // checkCub
            // 
            this.checkCub.AutoSize = true;
            this.checkCub.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkCub.Location = new System.Drawing.Point(197, 4);
            this.checkCub.Name = "checkCub";
            this.checkCub.Size = new System.Drawing.Size(61, 17);
            this.checkCub.TabIndex = 15;
            this.checkCub.Text = "кубици";
            this.checkCub.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(33, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Избери:";
            // 
            // DropDown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(661, 369);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkCub);
            this.Controls.Add(this.checkMeters);
            this.Controls.Add(this.buttonResult);
            this.Controls.Add(this.textResult);
            this.Controls.Add(this.textQuantity);
            this.Controls.Add(this.count);
            this.Controls.Add(this.result);
            this.Controls.Add(this.textHeight);
            this.Controls.Add(this.textWide);
            this.Controls.Add(this.textLength);
            this.Controls.Add(this.heght);
            this.Controls.Add(this.wide);
            this.Controls.Add(this.length);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DropDown";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label length;
        private System.Windows.Forms.Label wide;
        private System.Windows.Forms.Label heght;
        private System.Windows.Forms.TextBox textLength;
        private System.Windows.Forms.TextBox textWide;
        private System.Windows.Forms.TextBox textHeight;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label count;
        private System.Windows.Forms.TextBox textQuantity;
        private System.Windows.Forms.TextBox textResult;
        private System.Windows.Forms.Button buttonResult;
        private System.Windows.Forms.CheckBox checkMeters;
        private System.Windows.Forms.CheckBox checkCub;
        private System.Windows.Forms.Label label1;
    }
}

