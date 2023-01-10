using ReaLTaiizor.Forms;
namespace ReplaceTool
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region Windows 窗体设计器生成的代码
        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.MinBtn = new FontAwesome.Sharp.IconButton();
            this.CloseBtn = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.OutPutTextBox = new ICSharpCode.TextEditor.TextEditorControl();
            this.panel4 = new ReaLTaiizor.Controls.Panel();
            this.InputTextBox = new System.Windows.Forms.RichTextBox();
            this.toolbarGenerate = new ReaLTaiizor.Controls.TabPage();
            this.常用工具 = new System.Windows.Forms.TabPage();
            this.HtmlFormatterBtn = new System.Windows.Forms.Button();
            this.JsonFormatBtn = new System.Windows.Forms.Button();
            this.ChangToUtf8Btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TableNameBox = new ReaLTaiizor.Controls.BigTextBox();
            this.PdmGetCSharpCodeBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.GeneratNetPropertyWithSetGetBtn = new System.Windows.Forms.Button();
            this.OutPutBox = new System.Windows.Forms.TextBox();
            this.colNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.GenerateNetPropertyBtn = new System.Windows.Forms.Button();
            this.SqlParaReplaceBtn = new System.Windows.Forms.Button();
            this.propertyGenerateBtn = new System.Windows.Forms.Button();
            this.JsonToClassBtn = new System.Windows.Forms.Button();
            this.ToolBar生成 = new System.Windows.Forms.TabPage();
            this.CheckRegCodeBtn = new ReaLTaiizor.Controls.AirButton();
            this.AddAuthCodeBtn = new ReaLTaiizor.Controls.AirButton();
            this.GenerateToolBarTextBtn = new ReaLTaiizor.Controls.AirButton();
            this.参数命名 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.字符串处理 = new System.Windows.Forms.TabPage();
            this.fromNumberBox = new System.Windows.Forms.TextBox();
            this.toNumberBox = new System.Windows.Forms.TextBox();
            this.AddItSelf = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.contactText = new System.Windows.Forms.TextBox();
            this.contactTxtBtn = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.多字符替换 = new System.Windows.Forms.TabPage();
            this.ReplaceBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtdAddRow = new System.Windows.Forms.Button();
            this.SettingListBox = new System.Windows.Forms.ComboBox();
            this.ConfigDelBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.PageTableNameBox = new ReaLTaiizor.Controls.BigTextBox();
            this.PageGenerateBtn = new ReaLTaiizor.Controls.AirButton();
            this.label11 = new System.Windows.Forms.Label();
            this.TableTitleBox = new ReaLTaiizor.Controls.BigTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.HandlerPathBox = new ReaLTaiizor.Controls.BigTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.PagePathBox = new ReaLTaiizor.Controls.BigTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.toolbarGenerate.SuspendLayout();
            this.常用工具.SuspendLayout();
            this.ToolBar生成.SuspendLayout();
            this.参数命名.SuspendLayout();
            this.字符串处理.SuspendLayout();
            this.多字符替换.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.MinBtn);
            this.panel1.Controls.Add(this.CloseBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(972, 37);
            this.panel1.TabIndex = 33;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown_1);
            // 
            // MinBtn
            // 
            this.MinBtn.BackColor = System.Drawing.Color.Transparent;
            this.MinBtn.FlatAppearance.BorderSize = 0;
            this.MinBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.MinBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinBtn.IconChar = FontAwesome.Sharp.IconChar.Circle;
            this.MinBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(190)))), ((int)(((byte)(47)))));
            this.MinBtn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.MinBtn.IconSize = 18;
            this.MinBtn.Location = new System.Drawing.Point(918, 10);
            this.MinBtn.Name = "MinBtn";
            this.MinBtn.Size = new System.Drawing.Size(20, 19);
            this.MinBtn.TabIndex = 1;
            this.MinBtn.UseVisualStyleBackColor = false;
            this.MinBtn.Click += new System.EventHandler(this.MinBtn_Click);
            this.MinBtn.MouseLeave += new System.EventHandler(this.MinBtn_MouseLeave);
            this.MinBtn.MouseHover += new System.EventHandler(this.MinBtn_MouseHover);
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.Color.Transparent;
            this.CloseBtn.FlatAppearance.BorderSize = 0;
            this.CloseBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.IconChar = FontAwesome.Sharp.IconChar.Circle;
            this.CloseBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(96)))), ((int)(((byte)(88)))));
            this.CloseBtn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.CloseBtn.IconSize = 18;
            this.CloseBtn.Location = new System.Drawing.Point(944, 10);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(20, 19);
            this.CloseBtn.TabIndex = 0;
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.iconButton1_Click);
            this.CloseBtn.MouseLeave += new System.EventHandler(this.CloseBtn_MouseLeave);
            this.CloseBtn.MouseHover += new System.EventHandler(this.iconButton1_MouseHover);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.toolbarGenerate);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(972, 797);
            this.panel2.TabIndex = 34;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(972, 338);
            this.panel3.TabIndex = 31;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panel5.Controls.Add(this.OutPutTextBox);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(469, 0);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(5);
            this.panel5.Size = new System.Drawing.Size(503, 338);
            this.panel5.TabIndex = 12;
            // 
            // OutPutTextBox
            // 
            this.OutPutTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OutPutTextBox.Highlighting = null;
            this.OutPutTextBox.Location = new System.Drawing.Point(5, 5);
            this.OutPutTextBox.Name = "OutPutTextBox";
            this.OutPutTextBox.Size = new System.Drawing.Size(493, 328);
            this.OutPutTextBox.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panel4.Controls.Add(this.InputTextBox);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.EdgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(5);
            this.panel4.Size = new System.Drawing.Size(468, 338);
            this.panel4.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.panel4.TabIndex = 11;
            this.panel4.Text = "panel4";
            // 
            // InputTextBox
            // 
            this.InputTextBox.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.InputTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InputTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InputTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.InputTextBox.Location = new System.Drawing.Point(5, 5);
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(458, 328);
            this.InputTextBox.TabIndex = 9;
            this.InputTextBox.Text = "";
            // 
            // toolbarGenerate
            // 
            this.toolbarGenerate.ActiveForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.toolbarGenerate.ActiveLineTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.toolbarGenerate.ActiveTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.toolbarGenerate.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.toolbarGenerate.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighSpeed;
            this.toolbarGenerate.CompositingType = System.Drawing.Drawing2D.CompositingMode.SourceOver;
            this.toolbarGenerate.ControlBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(64)))));
            this.toolbarGenerate.Controls.Add(this.常用工具);
            this.toolbarGenerate.Controls.Add(this.ToolBar生成);
            this.toolbarGenerate.Controls.Add(this.参数命名);
            this.toolbarGenerate.Controls.Add(this.字符串处理);
            this.toolbarGenerate.Controls.Add(this.多字符替换);
            this.toolbarGenerate.Controls.Add(this.tabPage1);
            this.toolbarGenerate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolbarGenerate.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.toolbarGenerate.FrameColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(63)))));
            this.toolbarGenerate.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            this.toolbarGenerate.ItemSize = new System.Drawing.Size(44, 135);
            this.toolbarGenerate.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.toolbarGenerate.LineTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(64)))));
            this.toolbarGenerate.Location = new System.Drawing.Point(0, 339);
            this.toolbarGenerate.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.toolbarGenerate.Multiline = true;
            this.toolbarGenerate.Name = "toolbarGenerate";
            this.toolbarGenerate.NormalForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(162)))), ((int)(((byte)(167)))));
            this.toolbarGenerate.Padding = new System.Drawing.Point(300, 330);
            this.toolbarGenerate.PageColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(63)))), ((int)(((byte)(74)))));
            this.toolbarGenerate.SelectedIndex = 0;
            this.toolbarGenerate.Size = new System.Drawing.Size(972, 458);
            this.toolbarGenerate.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.toolbarGenerate.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.toolbarGenerate.StringType = System.Drawing.StringAlignment.Near;
            this.toolbarGenerate.TabColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(64)))));
            this.toolbarGenerate.TabIndex = 30;
            // 
            // 常用工具
            // 
            this.常用工具.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(63)))), ((int)(((byte)(74)))));
            this.常用工具.Controls.Add(this.HtmlFormatterBtn);
            this.常用工具.Controls.Add(this.JsonFormatBtn);
            this.常用工具.Controls.Add(this.ChangToUtf8Btn);
            this.常用工具.Controls.Add(this.label3);
            this.常用工具.Controls.Add(this.TableNameBox);
            this.常用工具.Controls.Add(this.PdmGetCSharpCodeBtn);
            this.常用工具.Controls.Add(this.label4);
            this.常用工具.Controls.Add(this.GeneratNetPropertyWithSetGetBtn);
            this.常用工具.Controls.Add(this.OutPutBox);
            this.常用工具.Controls.Add(this.colNo);
            this.常用工具.Controls.Add(this.label7);
            this.常用工具.Controls.Add(this.GenerateNetPropertyBtn);
            this.常用工具.Controls.Add(this.SqlParaReplaceBtn);
            this.常用工具.Controls.Add(this.propertyGenerateBtn);
            this.常用工具.Controls.Add(this.JsonToClassBtn);
            this.常用工具.Location = new System.Drawing.Point(139, 4);
            this.常用工具.Name = "常用工具";
            this.常用工具.Padding = new System.Windows.Forms.Padding(3);
            this.常用工具.Size = new System.Drawing.Size(829, 450);
            this.常用工具.TabIndex = 1;
            this.常用工具.Text = "常用工具";
            // 
            // HtmlFormatterBtn
            // 
            this.HtmlFormatterBtn.Location = new System.Drawing.Point(183, 19);
            this.HtmlFormatterBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HtmlFormatterBtn.Name = "HtmlFormatterBtn";
            this.HtmlFormatterBtn.Size = new System.Drawing.Size(100, 44);
            this.HtmlFormatterBtn.TabIndex = 35;
            this.HtmlFormatterBtn.Text = "Html格式化";
            this.HtmlFormatterBtn.UseVisualStyleBackColor = true;
            this.HtmlFormatterBtn.Click += new System.EventHandler(this.HtmlFormatterBtn_Click);
            // 
            // JsonFormatBtn
            // 
            this.JsonFormatBtn.Location = new System.Drawing.Point(32, 19);
            this.JsonFormatBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.JsonFormatBtn.Name = "JsonFormatBtn";
            this.JsonFormatBtn.Size = new System.Drawing.Size(100, 44);
            this.JsonFormatBtn.TabIndex = 34;
            this.JsonFormatBtn.Text = "Json格式化";
            this.JsonFormatBtn.UseVisualStyleBackColor = true;
            this.JsonFormatBtn.Click += new System.EventHandler(this.JsonFormatBtn_Click);
            // 
            // ChangToUtf8Btn
            // 
            this.ChangToUtf8Btn.Location = new System.Drawing.Point(32, 246);
            this.ChangToUtf8Btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ChangToUtf8Btn.Name = "ChangToUtf8Btn";
            this.ChangToUtf8Btn.Size = new System.Drawing.Size(124, 44);
            this.ChangToUtf8Btn.TabIndex = 33;
            this.ChangToUtf8Btn.Text = "文件夹下的文件更改成UTF-8格式";
            this.ChangToUtf8Btn.UseVisualStyleBackColor = true;
            this.ChangToUtf8Btn.Click += new System.EventHandler(this.ChangToUtf8Btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(26, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 31);
            this.label3.TabIndex = 32;
            this.label3.Text = "表名称";
            // 
            // TableNameBox
            // 
            this.TableNameBox.BackColor = System.Drawing.Color.Transparent;
            this.TableNameBox.Font = new System.Drawing.Font("Tahoma", 11F);
            this.TableNameBox.ForeColor = System.Drawing.Color.DimGray;
            this.TableNameBox.Image = null;
            this.TableNameBox.Location = new System.Drawing.Point(118, 177);
            this.TableNameBox.MaxLength = 32767;
            this.TableNameBox.Multiline = false;
            this.TableNameBox.Name = "TableNameBox";
            this.TableNameBox.ReadOnly = false;
            this.TableNameBox.Size = new System.Drawing.Size(100, 41);
            this.TableNameBox.TabIndex = 31;
            this.TableNameBox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.TableNameBox.UseSystemPasswordChar = false;
            // 
            // PdmGetCSharpCodeBtn
            // 
            this.PdmGetCSharpCodeBtn.Location = new System.Drawing.Point(224, 175);
            this.PdmGetCSharpCodeBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PdmGetCSharpCodeBtn.Name = "PdmGetCSharpCodeBtn";
            this.PdmGetCSharpCodeBtn.Size = new System.Drawing.Size(124, 44);
            this.PdmGetCSharpCodeBtn.TabIndex = 30;
            this.PdmGetCSharpCodeBtn.Text = "PDM生成C#类";
            this.PdmGetCSharpCodeBtn.UseVisualStyleBackColor = true;
            this.PdmGetCSharpCodeBtn.Click += new System.EventHandler(this.PdmGetCSharpCodeBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 559);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "输出内容";
            // 
            // GeneratNetPropertyWithSetGetBtn
            // 
            this.GeneratNetPropertyWithSetGetBtn.Location = new System.Drawing.Point(183, 94);
            this.GeneratNetPropertyWithSetGetBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GeneratNetPropertyWithSetGetBtn.Name = "GeneratNetPropertyWithSetGetBtn";
            this.GeneratNetPropertyWithSetGetBtn.Size = new System.Drawing.Size(135, 44);
            this.GeneratNetPropertyWithSetGetBtn.TabIndex = 29;
            this.GeneratNetPropertyWithSetGetBtn.Text = "生成GetSet方法";
            this.GeneratNetPropertyWithSetGetBtn.UseVisualStyleBackColor = true;
            this.GeneratNetPropertyWithSetGetBtn.Click += new System.EventHandler(this.button7_Click);
            // 
            // OutPutBox
            // 
            this.OutPutBox.Location = new System.Drawing.Point(88, 570);
            this.OutPutBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OutPutBox.Multiline = true;
            this.OutPutBox.Name = "OutPutBox";
            this.OutPutBox.Size = new System.Drawing.Size(559, 97);
            this.OutPutBox.TabIndex = 8;
            // 
            // colNo
            // 
            this.colNo.Location = new System.Drawing.Point(434, 108);
            this.colNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.colNo.Name = "colNo";
            this.colNo.Size = new System.Drawing.Size(38, 23);
            this.colNo.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(341, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 27;
            this.label7.Text = "注释所在列";
            // 
            // GenerateNetPropertyBtn
            // 
            this.GenerateNetPropertyBtn.Location = new System.Drawing.Point(32, 94);
            this.GenerateNetPropertyBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GenerateNetPropertyBtn.Name = "GenerateNetPropertyBtn";
            this.GenerateNetPropertyBtn.Size = new System.Drawing.Size(124, 44);
            this.GenerateNetPropertyBtn.TabIndex = 23;
            this.GenerateNetPropertyBtn.Text = "生成C#字段带注释";
            this.GenerateNetPropertyBtn.UseVisualStyleBackColor = true;
            this.GenerateNetPropertyBtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // SqlParaReplaceBtn
            // 
            this.SqlParaReplaceBtn.Location = new System.Drawing.Point(547, 19);
            this.SqlParaReplaceBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SqlParaReplaceBtn.Name = "SqlParaReplaceBtn";
            this.SqlParaReplaceBtn.Size = new System.Drawing.Size(100, 44);
            this.SqlParaReplaceBtn.TabIndex = 12;
            this.SqlParaReplaceBtn.Text = "Sql参数替换";
            this.SqlParaReplaceBtn.UseVisualStyleBackColor = true;
            this.SqlParaReplaceBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // propertyGenerateBtn
            // 
            this.propertyGenerateBtn.Location = new System.Drawing.Point(678, 19);
            this.propertyGenerateBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.propertyGenerateBtn.Name = "propertyGenerateBtn";
            this.propertyGenerateBtn.Size = new System.Drawing.Size(94, 44);
            this.propertyGenerateBtn.TabIndex = 22;
            this.propertyGenerateBtn.Text = "生成C#字段";
            this.propertyGenerateBtn.UseVisualStyleBackColor = true;
            this.propertyGenerateBtn.Click += new System.EventHandler(this.propertyGenerateBtn_Click);
            // 
            // JsonToClassBtn
            // 
            this.JsonToClassBtn.Location = new System.Drawing.Point(413, 19);
            this.JsonToClassBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.JsonToClassBtn.Name = "JsonToClassBtn";
            this.JsonToClassBtn.Size = new System.Drawing.Size(100, 44);
            this.JsonToClassBtn.TabIndex = 21;
            this.JsonToClassBtn.Text = "Json生成C#类";
            this.JsonToClassBtn.UseVisualStyleBackColor = true;
            this.JsonToClassBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // ToolBar生成
            // 
            this.ToolBar生成.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(63)))), ((int)(((byte)(74)))));
            this.ToolBar生成.Controls.Add(this.CheckRegCodeBtn);
            this.ToolBar生成.Controls.Add(this.AddAuthCodeBtn);
            this.ToolBar生成.Controls.Add(this.GenerateToolBarTextBtn);
            this.ToolBar生成.Location = new System.Drawing.Point(139, 4);
            this.ToolBar生成.Name = "ToolBar生成";
            this.ToolBar生成.Padding = new System.Windows.Forms.Padding(3);
            this.ToolBar生成.Size = new System.Drawing.Size(829, 450);
            this.ToolBar生成.TabIndex = 2;
            this.ToolBar生成.Text = "ToolBar生成";
            // 
            // CheckRegCodeBtn
            // 
            this.CheckRegCodeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckRegCodeBtn.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            this.CheckRegCodeBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CheckRegCodeBtn.Image = null;
            this.CheckRegCodeBtn.Location = new System.Drawing.Point(18, 218);
            this.CheckRegCodeBtn.Name = "CheckRegCodeBtn";
            this.CheckRegCodeBtn.NoRounding = false;
            this.CheckRegCodeBtn.Size = new System.Drawing.Size(215, 47);
            this.CheckRegCodeBtn.TabIndex = 2;
            this.CheckRegCodeBtn.Text = "检查特定HTML中是否有权限代码";
            this.CheckRegCodeBtn.Transparent = false;
            this.CheckRegCodeBtn.Click += new System.EventHandler(this.CheckRegCodeBtn_Click);
            // 
            // AddAuthCodeBtn
            // 
            this.AddAuthCodeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddAuthCodeBtn.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            this.AddAuthCodeBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AddAuthCodeBtn.Image = null;
            this.AddAuthCodeBtn.Location = new System.Drawing.Point(18, 110);
            this.AddAuthCodeBtn.Name = "AddAuthCodeBtn";
            this.AddAuthCodeBtn.NoRounding = false;
            this.AddAuthCodeBtn.Size = new System.Drawing.Size(140, 47);
            this.AddAuthCodeBtn.TabIndex = 1;
            this.AddAuthCodeBtn.Text = "添加权限代码到html中";
            this.AddAuthCodeBtn.Transparent = false;
            this.AddAuthCodeBtn.Click += new System.EventHandler(this.AddAuthCodeBtn_Click);
            // 
            // GenerateToolBarTextBtn
            // 
            this.GenerateToolBarTextBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GenerateToolBarTextBtn.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            this.GenerateToolBarTextBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GenerateToolBarTextBtn.Image = null;
            this.GenerateToolBarTextBtn.Location = new System.Drawing.Point(18, 16);
            this.GenerateToolBarTextBtn.Name = "GenerateToolBarTextBtn";
            this.GenerateToolBarTextBtn.NoRounding = false;
            this.GenerateToolBarTextBtn.Size = new System.Drawing.Size(123, 47);
            this.GenerateToolBarTextBtn.TabIndex = 0;
            this.GenerateToolBarTextBtn.Text = "生成Toolbar文本";
            this.GenerateToolBarTextBtn.Transparent = false;
            this.GenerateToolBarTextBtn.Click += new System.EventHandler(this.GenerateToolBarTextBtn_Click);
            // 
            // 参数命名
            // 
            this.参数命名.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(63)))), ((int)(((byte)(74)))));
            this.参数命名.Controls.Add(this.button2);
            this.参数命名.Location = new System.Drawing.Point(139, 4);
            this.参数命名.Name = "参数命名";
            this.参数命名.Padding = new System.Windows.Forms.Padding(3);
            this.参数命名.Size = new System.Drawing.Size(829, 450);
            this.参数命名.TabIndex = 3;
            this.参数命名.Text = "参数命名";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(29, 30);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 44);
            this.button2.TabIndex = 14;
            this.button2.Text = "转驼峰";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // 字符串处理
            // 
            this.字符串处理.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(63)))), ((int)(((byte)(74)))));
            this.字符串处理.Controls.Add(this.fromNumberBox);
            this.字符串处理.Controls.Add(this.toNumberBox);
            this.字符串处理.Controls.Add(this.AddItSelf);
            this.字符串处理.Controls.Add(this.label5);
            this.字符串处理.Controls.Add(this.label6);
            this.字符串处理.Controls.Add(this.contactText);
            this.字符串处理.Controls.Add(this.contactTxtBtn);
            this.字符串处理.Controls.Add(this.button5);
            this.字符串处理.Location = new System.Drawing.Point(139, 4);
            this.字符串处理.Name = "字符串处理";
            this.字符串处理.Size = new System.Drawing.Size(829, 450);
            this.字符串处理.TabIndex = 4;
            this.字符串处理.Text = "字符串处理";
            // 
            // fromNumberBox
            // 
            this.fromNumberBox.Location = new System.Drawing.Point(350, 176);
            this.fromNumberBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fromNumberBox.Name = "fromNumberBox";
            this.fromNumberBox.Size = new System.Drawing.Size(41, 23);
            this.fromNumberBox.TabIndex = 29;
            // 
            // toNumberBox
            // 
            this.toNumberBox.Location = new System.Drawing.Point(435, 176);
            this.toNumberBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.toNumberBox.Name = "toNumberBox";
            this.toNumberBox.Size = new System.Drawing.Size(41, 23);
            this.toNumberBox.TabIndex = 32;
            // 
            // AddItSelf
            // 
            this.AddItSelf.Location = new System.Drawing.Point(27, 166);
            this.AddItSelf.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddItSelf.Name = "AddItSelf";
            this.AddItSelf.Size = new System.Drawing.Size(281, 44);
            this.AddItSelf.TabIndex = 28;
            this.AddItSelf.Text = "替换数值添加到本身,后面设置加到几";
            this.AddItSelf.UseVisualStyleBackColor = true;
            this.AddItSelf.Click += new System.EventHandler(this.AddItSelf_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(408, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 17);
            this.label5.TabIndex = 30;
            this.label5.Text = "到";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(323, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 17);
            this.label6.TabIndex = 31;
            this.label6.Text = "从";
            // 
            // contactText
            // 
            this.contactText.Location = new System.Drawing.Point(179, 97);
            this.contactText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.contactText.Multiline = true;
            this.contactText.Name = "contactText";
            this.contactText.Size = new System.Drawing.Size(48, 43);
            this.contactText.TabIndex = 27;
            // 
            // contactTxtBtn
            // 
            this.contactTxtBtn.Location = new System.Drawing.Point(27, 97);
            this.contactTxtBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.contactTxtBtn.Name = "contactTxtBtn";
            this.contactTxtBtn.Size = new System.Drawing.Size(135, 43);
            this.contactTxtBtn.TabIndex = 26;
            this.contactTxtBtn.Text = "使用后面的符号拼接";
            this.contactTxtBtn.UseVisualStyleBackColor = true;
            this.contactTxtBtn.Click += new System.EventHandler(this.contactTxtBtn_Click_1);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(27, 33);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(135, 44);
            this.button5.TabIndex = 25;
            this.button5.Text = "转成字符串";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // 多字符替换
            // 
            this.多字符替换.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(63)))), ((int)(((byte)(74)))));
            this.多字符替换.Controls.Add(this.ReplaceBtn);
            this.多字符替换.Controls.Add(this.label1);
            this.多字符替换.Controls.Add(this.BtdAddRow);
            this.多字符替换.Controls.Add(this.SettingListBox);
            this.多字符替换.Controls.Add(this.ConfigDelBtn);
            this.多字符替换.Controls.Add(this.dataGridView1);
            this.多字符替换.Location = new System.Drawing.Point(139, 4);
            this.多字符替换.Name = "多字符替换";
            this.多字符替换.Size = new System.Drawing.Size(829, 450);
            this.多字符替换.TabIndex = 5;
            this.多字符替换.Text = "多字符替换";
            // 
            // ReplaceBtn
            // 
            this.ReplaceBtn.Location = new System.Drawing.Point(335, 363);
            this.ReplaceBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ReplaceBtn.Name = "ReplaceBtn";
            this.ReplaceBtn.Size = new System.Drawing.Size(100, 44);
            this.ReplaceBtn.TabIndex = 32;
            this.ReplaceBtn.Text = "替换";
            this.ReplaceBtn.UseVisualStyleBackColor = true;
            this.ReplaceBtn.Click += new System.EventHandler(this.ReplaceBtn_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(20, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 35);
            this.label1.TabIndex = 27;
            this.label1.Text = "配置";
            // 
            // BtdAddRow
            // 
            this.BtdAddRow.Location = new System.Drawing.Point(19, 363);
            this.BtdAddRow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtdAddRow.Name = "BtdAddRow";
            this.BtdAddRow.Size = new System.Drawing.Size(96, 44);
            this.BtdAddRow.TabIndex = 26;
            this.BtdAddRow.Text = "保存配置";
            this.BtdAddRow.UseVisualStyleBackColor = true;
            this.BtdAddRow.Click += new System.EventHandler(this.BtdAddRow_Click_1);
            // 
            // SettingListBox
            // 
            this.SettingListBox.FormattingEnabled = true;
            this.SettingListBox.Location = new System.Drawing.Point(110, 251);
            this.SettingListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SettingListBox.Name = "SettingListBox";
            this.SettingListBox.Size = new System.Drawing.Size(287, 25);
            this.SettingListBox.TabIndex = 28;
            this.SettingListBox.SelectedIndexChanged += new System.EventHandler(this.SettingListBox_SelectedIndexChanged_1);
            // 
            // ConfigDelBtn
            // 
            this.ConfigDelBtn.Location = new System.Drawing.Point(180, 363);
            this.ConfigDelBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConfigDelBtn.Name = "ConfigDelBtn";
            this.ConfigDelBtn.Size = new System.Drawing.Size(96, 44);
            this.ConfigDelBtn.TabIndex = 31;
            this.ConfigDelBtn.Text = "删除配置";
            this.ConfigDelBtn.UseVisualStyleBackColor = true;
            this.ConfigDelBtn.Click += new System.EventHandler(this.ConfigDelBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(63)))), ((int)(((byte)(74)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(829, 199);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView1_EditingControlShowing);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(63)))), ((int)(((byte)(74)))));
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.PageTableNameBox);
            this.tabPage1.Controls.Add(this.PageGenerateBtn);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.TableTitleBox);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.HandlerPathBox);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.PagePathBox);
            this.tabPage1.Location = new System.Drawing.Point(139, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(829, 450);
            this.tabPage1.TabIndex = 6;
            this.tabPage1.Text = "页面生成";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(35, 205);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 28);
            this.label9.TabIndex = 43;
            this.label9.Text = "表名称";
            // 
            // PageTableNameBox
            // 
            this.PageTableNameBox.BackColor = System.Drawing.Color.Transparent;
            this.PageTableNameBox.Font = new System.Drawing.Font("Tahoma", 11F);
            this.PageTableNameBox.ForeColor = System.Drawing.Color.DimGray;
            this.PageTableNameBox.Image = null;
            this.PageTableNameBox.Location = new System.Drawing.Point(224, 205);
            this.PageTableNameBox.MaxLength = 32767;
            this.PageTableNameBox.Multiline = false;
            this.PageTableNameBox.Name = "PageTableNameBox";
            this.PageTableNameBox.ReadOnly = false;
            this.PageTableNameBox.Size = new System.Drawing.Size(417, 41);
            this.PageTableNameBox.TabIndex = 42;
            this.PageTableNameBox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.PageTableNameBox.UseSystemPasswordChar = false;
            // 
            // PageGenerateBtn
            // 
            this.PageGenerateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PageGenerateBtn.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            this.PageGenerateBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PageGenerateBtn.Image = null;
            this.PageGenerateBtn.Location = new System.Drawing.Point(31, 281);
            this.PageGenerateBtn.Name = "PageGenerateBtn";
            this.PageGenerateBtn.NoRounding = false;
            this.PageGenerateBtn.Size = new System.Drawing.Size(123, 47);
            this.PageGenerateBtn.TabIndex = 41;
            this.PageGenerateBtn.Text = "页面生成";
            this.PageGenerateBtn.Transparent = false;
            this.PageGenerateBtn.Click += new System.EventHandler(this.PageGenerateBtn_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(35, 142);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 28);
            this.label11.TabIndex = 40;
            this.label11.Text = "标题";
            // 
            // TableTitleBox
            // 
            this.TableTitleBox.BackColor = System.Drawing.Color.Transparent;
            this.TableTitleBox.Font = new System.Drawing.Font("Tahoma", 11F);
            this.TableTitleBox.ForeColor = System.Drawing.Color.DimGray;
            this.TableTitleBox.Image = null;
            this.TableTitleBox.Location = new System.Drawing.Point(224, 142);
            this.TableTitleBox.MaxLength = 32767;
            this.TableTitleBox.Multiline = false;
            this.TableTitleBox.Name = "TableTitleBox";
            this.TableTitleBox.ReadOnly = false;
            this.TableTitleBox.Size = new System.Drawing.Size(417, 41);
            this.TableTitleBox.TabIndex = 39;
            this.TableTitleBox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.TableTitleBox.UseSystemPasswordChar = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(26, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(180, 28);
            this.label10.TabIndex = 38;
            this.label10.Text = "一般处理程序路径";
            // 
            // HandlerPathBox
            // 
            this.HandlerPathBox.BackColor = System.Drawing.Color.Transparent;
            this.HandlerPathBox.Font = new System.Drawing.Font("Tahoma", 11F);
            this.HandlerPathBox.ForeColor = System.Drawing.Color.DimGray;
            this.HandlerPathBox.Image = null;
            this.HandlerPathBox.Location = new System.Drawing.Point(224, 76);
            this.HandlerPathBox.MaxLength = 32767;
            this.HandlerPathBox.Multiline = false;
            this.HandlerPathBox.Name = "HandlerPathBox";
            this.HandlerPathBox.ReadOnly = false;
            this.HandlerPathBox.Size = new System.Drawing.Size(417, 41);
            this.HandlerPathBox.TabIndex = 37;
            this.HandlerPathBox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.HandlerPathBox.UseSystemPasswordChar = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(26, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 28);
            this.label8.TabIndex = 34;
            this.label8.Text = "页面路径";
            // 
            // PagePathBox
            // 
            this.PagePathBox.BackColor = System.Drawing.Color.Transparent;
            this.PagePathBox.Font = new System.Drawing.Font("Tahoma", 11F);
            this.PagePathBox.ForeColor = System.Drawing.Color.DimGray;
            this.PagePathBox.Image = null;
            this.PagePathBox.Location = new System.Drawing.Point(224, 6);
            this.PagePathBox.MaxLength = 32767;
            this.PagePathBox.Multiline = false;
            this.PagePathBox.Name = "PagePathBox";
            this.PagePathBox.ReadOnly = false;
            this.PagePathBox.Size = new System.Drawing.Size(417, 41);
            this.PagePathBox.TabIndex = 33;
            this.PagePathBox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.PagePathBox.UseSystemPasswordChar = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(972, 834);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "常用功能";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.toolbarGenerate.ResumeLayout(false);
            this.常用工具.ResumeLayout(false);
            this.常用工具.PerformLayout();
            this.ToolBar生成.ResumeLayout(false);
            this.参数命名.ResumeLayout(false);
            this.字符串处理.ResumeLayout(false);
            this.字符串处理.PerformLayout();
            this.多字符替换.ResumeLayout(false);
            this.多字符替换.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.Panel panel1;
        private ReaLTaiizor.Controls.TabPage toolbarGenerate;
        private System.Windows.Forms.TabPage 常用工具;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button GeneratNetPropertyWithSetGetBtn;
        private System.Windows.Forms.TextBox OutPutBox;
        private System.Windows.Forms.TextBox colNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button GenerateNetPropertyBtn;
        private System.Windows.Forms.Button SqlParaReplaceBtn;
        private System.Windows.Forms.Button propertyGenerateBtn;
        private System.Windows.Forms.Button JsonToClassBtn;
        private System.Windows.Forms.TabPage ToolBar生成;
        private ReaLTaiizor.Controls.AirButton GenerateToolBarTextBtn;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton CloseBtn;
        private System.Windows.Forms.RichTextBox InputTextBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private ReaLTaiizor.Controls.Panel panel4;
        private System.Windows.Forms.TabPage 参数命名;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabPage 字符串处理;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox contactText;
        private System.Windows.Forms.Button contactTxtBtn;
        private System.Windows.Forms.TextBox fromNumberBox;
        private System.Windows.Forms.TextBox toNumberBox;
        private System.Windows.Forms.Button AddItSelf;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage 多字符替换;
        private System.Windows.Forms.Button ReplaceBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtdAddRow;
        private System.Windows.Forms.ComboBox SettingListBox;
        private System.Windows.Forms.Button ConfigDelBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ReaLTaiizor.Controls.AirButton AddAuthCodeBtn;
        private ReaLTaiizor.Controls.AirButton CheckRegCodeBtn;
        private System.Windows.Forms.Button PdmGetCSharpCodeBtn;
        private ReaLTaiizor.Controls.BigTextBox TableNameBox;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton MinBtn;
        private System.Windows.Forms.Button ChangToUtf8Btn;
        private System.Windows.Forms.Button JsonFormatBtn;
        private ICSharpCode.TextEditor.TextEditorControl OutPutTextBox;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label11;
        private ReaLTaiizor.Controls.BigTextBox TableTitleBox;
        private System.Windows.Forms.Label label10;
        private ReaLTaiizor.Controls.BigTextBox HandlerPathBox;
        private System.Windows.Forms.Label label8;
        private ReaLTaiizor.Controls.BigTextBox PagePathBox;
        private ReaLTaiizor.Controls.AirButton PageGenerateBtn;
        private System.Windows.Forms.Label label9;
        private ReaLTaiizor.Controls.BigTextBox PageTableNameBox;
        private System.Windows.Forms.Button HtmlFormatterBtn;
    }
}
