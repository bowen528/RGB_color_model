
namespace RGB_color_model
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lab_Opt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.hSBR = new System.Windows.Forms.HScrollBar();
            this.hSBG = new System.Windows.Forms.HScrollBar();
            this.hSBB = new System.Windows.Forms.HScrollBar();
            this.LR = new System.Windows.Forms.Label();
            this.LG = new System.Windows.Forms.Label();
            this.LB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lab_Opt
            // 
            this.lab_Opt.Font = new System.Drawing.Font("UD Digi Kyokasho NP-B", 90F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lab_Opt.Location = new System.Drawing.Point(88, 33);
            this.lab_Opt.Name = "lab_Opt";
            this.lab_Opt.Size = new System.Drawing.Size(179, 162);
            this.lab_Opt.TabIndex = 2;
            this.lab_Opt.Text = "愷";
            this.lab_Opt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(40, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "R：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(39, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "G：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(41, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "B：";
            // 
            // hSBR
            // 
            this.hSBR.Location = new System.Drawing.Point(102, 211);
            this.hSBR.Name = "hSBR";
            this.hSBR.Size = new System.Drawing.Size(151, 31);
            this.hSBR.TabIndex = 4;
            this.hSBR.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hSBR_Scroll);
            // 
            // hSBG
            // 
            this.hSBG.Location = new System.Drawing.Point(102, 261);
            this.hSBG.Name = "hSBG";
            this.hSBG.Size = new System.Drawing.Size(151, 31);
            this.hSBG.TabIndex = 4;
            this.hSBG.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hSBG_Scroll);
            // 
            // hSBB
            // 
            this.hSBB.Location = new System.Drawing.Point(102, 312);
            this.hSBB.Name = "hSBB";
            this.hSBB.Size = new System.Drawing.Size(151, 31);
            this.hSBB.TabIndex = 4;
            this.hSBB.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hSBB_Scroll);
            // 
            // LR
            // 
            this.LR.AutoSize = true;
            this.LR.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LR.Location = new System.Drawing.Point(274, 211);
            this.LR.Name = "LR";
            this.LR.Size = new System.Drawing.Size(43, 31);
            this.LR.TabIndex = 5;
            this.LR.Text = "LR";
            // 
            // LG
            // 
            this.LG.AutoSize = true;
            this.LG.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LG.Location = new System.Drawing.Point(273, 261);
            this.LG.Name = "LG";
            this.LG.Size = new System.Drawing.Size(45, 31);
            this.LG.TabIndex = 5;
            this.LG.Text = "LG";
            // 
            // LB
            // 
            this.LB.AutoSize = true;
            this.LB.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB.Location = new System.Drawing.Point(274, 312);
            this.LB.Name = "LB";
            this.LB.Size = new System.Drawing.Size(42, 31);
            this.LB.TabIndex = 5;
            this.LB.Text = "LB";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 386);
            this.ControlBox = false;
            this.Controls.Add(this.LB);
            this.Controls.Add(this.LG);
            this.Controls.Add(this.LR);
            this.Controls.Add(this.hSBB);
            this.Controls.Add(this.hSBG);
            this.Controls.Add(this.hSBR);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lab_Opt);
            this.Name = "MainForm";
            this.Text = "RGB_color";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lab_Opt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.HScrollBar hSBR;
        private System.Windows.Forms.HScrollBar hSBG;
        private System.Windows.Forms.HScrollBar hSBB;
        private System.Windows.Forms.Label LR;
        private System.Windows.Forms.Label LG;
        private System.Windows.Forms.Label LB;
    }
}

