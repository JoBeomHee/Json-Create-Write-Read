namespace JsonTest
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.uiBtn_CreateJson = new System.Windows.Forms.Button();
            this.uiBtn_WriteJson = new System.Windows.Forms.Button();
            this.uiBtn_ReadJson = new System.Windows.Forms.Button();
            this.uiRtb_Text = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.41614F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.58386F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(665, 471);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.uiBtn_ReadJson, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.uiBtn_WriteJson, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.uiBtn_CreateJson, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(659, 108);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.uiRtb_Text);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 117);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(659, 351);
            this.panel1.TabIndex = 1;
            // 
            // uiBtn_CreateJson
            // 
            this.uiBtn_CreateJson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiBtn_CreateJson.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiBtn_CreateJson.Location = new System.Drawing.Point(3, 3);
            this.uiBtn_CreateJson.Name = "uiBtn_CreateJson";
            this.uiBtn_CreateJson.Size = new System.Drawing.Size(213, 102);
            this.uiBtn_CreateJson.TabIndex = 0;
            this.uiBtn_CreateJson.Text = "Create JSON";
            this.uiBtn_CreateJson.UseVisualStyleBackColor = true;
            // 
            // uiBtn_WriteJson
            // 
            this.uiBtn_WriteJson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiBtn_WriteJson.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiBtn_WriteJson.Location = new System.Drawing.Point(222, 3);
            this.uiBtn_WriteJson.Name = "uiBtn_WriteJson";
            this.uiBtn_WriteJson.Size = new System.Drawing.Size(213, 102);
            this.uiBtn_WriteJson.TabIndex = 1;
            this.uiBtn_WriteJson.Text = "Write JSON";
            this.uiBtn_WriteJson.UseVisualStyleBackColor = true;
            // 
            // uiBtn_ReadJson
            // 
            this.uiBtn_ReadJson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiBtn_ReadJson.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiBtn_ReadJson.Location = new System.Drawing.Point(441, 3);
            this.uiBtn_ReadJson.Name = "uiBtn_ReadJson";
            this.uiBtn_ReadJson.Size = new System.Drawing.Size(215, 102);
            this.uiBtn_ReadJson.TabIndex = 2;
            this.uiBtn_ReadJson.Text = "Read Json";
            this.uiBtn_ReadJson.UseVisualStyleBackColor = true;
            // 
            // uiRtb_Text
            // 
            this.uiRtb_Text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiRtb_Text.Location = new System.Drawing.Point(0, 0);
            this.uiRtb_Text.Name = "uiRtb_Text";
            this.uiRtb_Text.Size = new System.Drawing.Size(659, 351);
            this.uiRtb_Text.TabIndex = 0;
            this.uiRtb_Text.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 471);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "JSON Test";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button uiBtn_ReadJson;
        private System.Windows.Forms.Button uiBtn_WriteJson;
        private System.Windows.Forms.Button uiBtn_CreateJson;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox uiRtb_Text;
    }
}

