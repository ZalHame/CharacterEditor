namespace CharacterEditor
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.ListChar = new System.Windows.Forms.ListBox();
            this.LabelDef = new System.Windows.Forms.Label();
            this.LabelMAtt = new System.Windows.Forms.Label();
            this.LabelAtt = new System.Windows.Forms.Label();
            this.LabelMP = new System.Windows.Forms.Label();
            this.LabelHP = new System.Windows.Forms.Label();
            this.labelnameMAtt = new System.Windows.Forms.Label();
            this.labelnameDef = new System.Windows.Forms.Label();
            this.labelnameAtt = new System.Windows.Forms.Label();
            this.labelnameMP = new System.Windows.Forms.Label();
            this.labelnameHP = new System.Windows.Forms.Label();
            this.ButtonIntPlus = new System.Windows.Forms.Button();
            this.ButtonConsPlus = new System.Windows.Forms.Button();
            this.ButtonDexPlus = new System.Windows.Forms.Button();
            this.ButtonStrPlus = new System.Windows.Forms.Button();
            this.LabelInt = new System.Windows.Forms.Label();
            this.LabelCons = new System.Windows.Forms.Label();
            this.LabelDex = new System.Windows.Forms.Label();
            this.LabelStr = new System.Windows.Forms.Label();
            this.ButtonIntMinus = new System.Windows.Forms.Button();
            this.ButtonConsMinus = new System.Windows.Forms.Button();
            this.ButtonDexMinus = new System.Windows.Forms.Button();
            this.ButtonStrMinus = new System.Windows.Forms.Button();
            this.labelnameSkillPoint = new System.Windows.Forms.Label();
            this.LabelSkillPoint = new System.Windows.Forms.Label();
            this.Create = new System.Windows.Forms.Button();
            this.labelnameInt = new System.Windows.Forms.Label();
            this.labelnameCons = new System.Windows.Forms.Label();
            this.labelnameDex = new System.Windows.Forms.Label();
            this.labelnameStr = new System.Windows.Forms.Label();
            this.labelnameClass = new System.Windows.Forms.Label();
            this.labelnameNickname = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ComboBoxClass = new System.Windows.Forms.ComboBox();
            this.TextBoxNickname = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.ListChar);
            this.panel1.Controls.Add(this.LabelDef);
            this.panel1.Controls.Add(this.LabelMAtt);
            this.panel1.Controls.Add(this.LabelAtt);
            this.panel1.Controls.Add(this.LabelMP);
            this.panel1.Controls.Add(this.LabelHP);
            this.panel1.Controls.Add(this.labelnameMAtt);
            this.panel1.Controls.Add(this.labelnameDef);
            this.panel1.Controls.Add(this.labelnameAtt);
            this.panel1.Controls.Add(this.labelnameMP);
            this.panel1.Controls.Add(this.labelnameHP);
            this.panel1.Controls.Add(this.ButtonIntPlus);
            this.panel1.Controls.Add(this.ButtonConsPlus);
            this.panel1.Controls.Add(this.ButtonDexPlus);
            this.panel1.Controls.Add(this.ButtonStrPlus);
            this.panel1.Controls.Add(this.LabelInt);
            this.panel1.Controls.Add(this.LabelCons);
            this.panel1.Controls.Add(this.LabelDex);
            this.panel1.Controls.Add(this.LabelStr);
            this.panel1.Controls.Add(this.ButtonIntMinus);
            this.panel1.Controls.Add(this.ButtonConsMinus);
            this.panel1.Controls.Add(this.ButtonDexMinus);
            this.panel1.Controls.Add(this.ButtonStrMinus);
            this.panel1.Controls.Add(this.labelnameSkillPoint);
            this.panel1.Controls.Add(this.LabelSkillPoint);
            this.panel1.Controls.Add(this.Create);
            this.panel1.Controls.Add(this.labelnameInt);
            this.panel1.Controls.Add(this.labelnameCons);
            this.panel1.Controls.Add(this.labelnameDex);
            this.panel1.Controls.Add(this.labelnameStr);
            this.panel1.Controls.Add(this.labelnameClass);
            this.panel1.Controls.Add(this.labelnameNickname);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ComboBoxClass);
            this.panel1.Controls.Add(this.TextBoxNickname);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(826, 474);
            this.panel1.TabIndex = 0;
            // 
            // ListChar
            // 
            this.ListChar.FormattingEnabled = true;
            this.ListChar.Location = new System.Drawing.Point(34, 307);
            this.ListChar.Name = "ListChar";
            this.ListChar.Size = new System.Drawing.Size(146, 134);
            this.ListChar.TabIndex = 49;
            this.ListChar.SelectedIndexChanged += new System.EventHandler(this.ListChar_SelectedIndexChanged);
            // 
            // LabelDef
            // 
            this.LabelDef.AutoSize = true;
            this.LabelDef.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelDef.Location = new System.Drawing.Point(526, 229);
            this.LabelDef.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelDef.Name = "LabelDef";
            this.LabelDef.Size = new System.Drawing.Size(18, 20);
            this.LabelDef.TabIndex = 48;
            this.LabelDef.Text = "0";
            // 
            // LabelMAtt
            // 
            this.LabelMAtt.AutoSize = true;
            this.LabelMAtt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelMAtt.Location = new System.Drawing.Point(526, 209);
            this.LabelMAtt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelMAtt.Name = "LabelMAtt";
            this.LabelMAtt.Size = new System.Drawing.Size(18, 20);
            this.LabelMAtt.TabIndex = 47;
            this.LabelMAtt.Text = "0";
            // 
            // LabelAtt
            // 
            this.LabelAtt.AutoSize = true;
            this.LabelAtt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelAtt.Location = new System.Drawing.Point(526, 188);
            this.LabelAtt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelAtt.Name = "LabelAtt";
            this.LabelAtt.Size = new System.Drawing.Size(18, 20);
            this.LabelAtt.TabIndex = 46;
            this.LabelAtt.Text = "0";
            // 
            // LabelMP
            // 
            this.LabelMP.AutoSize = true;
            this.LabelMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelMP.Location = new System.Drawing.Point(526, 168);
            this.LabelMP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelMP.Name = "LabelMP";
            this.LabelMP.Size = new System.Drawing.Size(18, 20);
            this.LabelMP.TabIndex = 45;
            this.LabelMP.Text = "0";
            // 
            // LabelHP
            // 
            this.LabelHP.AutoSize = true;
            this.LabelHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelHP.Location = new System.Drawing.Point(526, 148);
            this.LabelHP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelHP.Name = "LabelHP";
            this.LabelHP.Size = new System.Drawing.Size(18, 20);
            this.LabelHP.TabIndex = 44;
            this.LabelHP.Text = "0";
            // 
            // labelnameMAtt
            // 
            this.labelnameMAtt.AutoSize = true;
            this.labelnameMAtt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelnameMAtt.Location = new System.Drawing.Point(433, 209);
            this.labelnameMAtt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelnameMAtt.Name = "labelnameMAtt";
            this.labelnameMAtt.Size = new System.Drawing.Size(43, 20);
            this.labelnameMAtt.TabIndex = 43;
            this.labelnameMAtt.Text = "MAtt";
            // 
            // labelnameDef
            // 
            this.labelnameDef.AutoSize = true;
            this.labelnameDef.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelnameDef.Location = new System.Drawing.Point(433, 229);
            this.labelnameDef.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelnameDef.Name = "labelnameDef";
            this.labelnameDef.Size = new System.Drawing.Size(35, 20);
            this.labelnameDef.TabIndex = 42;
            this.labelnameDef.Text = "Def";
            // 
            // labelnameAtt
            // 
            this.labelnameAtt.AutoSize = true;
            this.labelnameAtt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelnameAtt.Location = new System.Drawing.Point(433, 188);
            this.labelnameAtt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelnameAtt.Name = "labelnameAtt";
            this.labelnameAtt.Size = new System.Drawing.Size(30, 20);
            this.labelnameAtt.TabIndex = 41;
            this.labelnameAtt.Text = "Att";
            // 
            // labelnameMP
            // 
            this.labelnameMP.AutoSize = true;
            this.labelnameMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelnameMP.Location = new System.Drawing.Point(433, 168);
            this.labelnameMP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelnameMP.Name = "labelnameMP";
            this.labelnameMP.Size = new System.Drawing.Size(32, 20);
            this.labelnameMP.TabIndex = 40;
            this.labelnameMP.Text = "MP";
            // 
            // labelnameHP
            // 
            this.labelnameHP.AutoSize = true;
            this.labelnameHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelnameHP.Location = new System.Drawing.Point(433, 148);
            this.labelnameHP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelnameHP.Name = "labelnameHP";
            this.labelnameHP.Size = new System.Drawing.Size(31, 20);
            this.labelnameHP.TabIndex = 39;
            this.labelnameHP.Text = "HP";
            // 
            // ButtonIntPlus
            // 
            this.ButtonIntPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonIntPlus.Location = new System.Drawing.Point(380, 209);
            this.ButtonIntPlus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonIntPlus.Name = "ButtonIntPlus";
            this.ButtonIntPlus.Size = new System.Drawing.Size(19, 20);
            this.ButtonIntPlus.TabIndex = 38;
            this.ButtonIntPlus.Text = "+";
            this.ButtonIntPlus.UseVisualStyleBackColor = true;
            this.ButtonIntPlus.Click += new System.EventHandler(this.ButtonIntPlus_Click);
            // 
            // ButtonConsPlus
            // 
            this.ButtonConsPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonConsPlus.Location = new System.Drawing.Point(380, 188);
            this.ButtonConsPlus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonConsPlus.Name = "ButtonConsPlus";
            this.ButtonConsPlus.Size = new System.Drawing.Size(19, 20);
            this.ButtonConsPlus.TabIndex = 37;
            this.ButtonConsPlus.Text = "+";
            this.ButtonConsPlus.UseVisualStyleBackColor = true;
            this.ButtonConsPlus.Click += new System.EventHandler(this.ButtonConsPlus_Click);
            // 
            // ButtonDexPlus
            // 
            this.ButtonDexPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonDexPlus.Location = new System.Drawing.Point(380, 168);
            this.ButtonDexPlus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonDexPlus.Name = "ButtonDexPlus";
            this.ButtonDexPlus.Size = new System.Drawing.Size(19, 20);
            this.ButtonDexPlus.TabIndex = 36;
            this.ButtonDexPlus.Text = "+";
            this.ButtonDexPlus.UseVisualStyleBackColor = true;
            this.ButtonDexPlus.Click += new System.EventHandler(this.ButtonDexPlus_Click);
            // 
            // ButtonStrPlus
            // 
            this.ButtonStrPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonStrPlus.Location = new System.Drawing.Point(380, 148);
            this.ButtonStrPlus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonStrPlus.Name = "ButtonStrPlus";
            this.ButtonStrPlus.Size = new System.Drawing.Size(19, 20);
            this.ButtonStrPlus.TabIndex = 35;
            this.ButtonStrPlus.Text = "+";
            this.ButtonStrPlus.UseVisualStyleBackColor = true;
            this.ButtonStrPlus.Click += new System.EventHandler(this.ButtonStrPlus_Click);
            // 
            // LabelInt
            // 
            this.LabelInt.AutoSize = true;
            this.LabelInt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelInt.Location = new System.Drawing.Point(308, 209);
            this.LabelInt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelInt.Name = "LabelInt";
            this.LabelInt.Size = new System.Drawing.Size(18, 20);
            this.LabelInt.TabIndex = 34;
            this.LabelInt.Text = "0";
            // 
            // LabelCons
            // 
            this.LabelCons.AutoSize = true;
            this.LabelCons.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelCons.Location = new System.Drawing.Point(308, 188);
            this.LabelCons.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelCons.Name = "LabelCons";
            this.LabelCons.Size = new System.Drawing.Size(18, 20);
            this.LabelCons.TabIndex = 33;
            this.LabelCons.Text = "0";
            // 
            // LabelDex
            // 
            this.LabelDex.AutoSize = true;
            this.LabelDex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelDex.Location = new System.Drawing.Point(308, 168);
            this.LabelDex.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelDex.Name = "LabelDex";
            this.LabelDex.Size = new System.Drawing.Size(18, 20);
            this.LabelDex.TabIndex = 32;
            this.LabelDex.Text = "0";
            // 
            // LabelStr
            // 
            this.LabelStr.AutoSize = true;
            this.LabelStr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelStr.Location = new System.Drawing.Point(308, 148);
            this.LabelStr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelStr.Name = "LabelStr";
            this.LabelStr.Size = new System.Drawing.Size(18, 20);
            this.LabelStr.TabIndex = 31;
            this.LabelStr.Text = "0";
            // 
            // ButtonIntMinus
            // 
            this.ButtonIntMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonIntMinus.Location = new System.Drawing.Point(356, 209);
            this.ButtonIntMinus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonIntMinus.Name = "ButtonIntMinus";
            this.ButtonIntMinus.Size = new System.Drawing.Size(19, 20);
            this.ButtonIntMinus.TabIndex = 30;
            this.ButtonIntMinus.Text = "-";
            this.ButtonIntMinus.UseVisualStyleBackColor = true;
            this.ButtonIntMinus.Click += new System.EventHandler(this.ButtonIntMinus_Click);
            // 
            // ButtonConsMinus
            // 
            this.ButtonConsMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonConsMinus.Location = new System.Drawing.Point(356, 188);
            this.ButtonConsMinus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonConsMinus.Name = "ButtonConsMinus";
            this.ButtonConsMinus.Size = new System.Drawing.Size(19, 20);
            this.ButtonConsMinus.TabIndex = 29;
            this.ButtonConsMinus.Text = "-";
            this.ButtonConsMinus.UseVisualStyleBackColor = true;
            this.ButtonConsMinus.Click += new System.EventHandler(this.ButtonConsMinus_Click);
            // 
            // ButtonDexMinus
            // 
            this.ButtonDexMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonDexMinus.Location = new System.Drawing.Point(356, 168);
            this.ButtonDexMinus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonDexMinus.Name = "ButtonDexMinus";
            this.ButtonDexMinus.Size = new System.Drawing.Size(19, 20);
            this.ButtonDexMinus.TabIndex = 28;
            this.ButtonDexMinus.Text = "-";
            this.ButtonDexMinus.UseVisualStyleBackColor = true;
            this.ButtonDexMinus.Click += new System.EventHandler(this.ButtonDexMinus_Click);
            // 
            // ButtonStrMinus
            // 
            this.ButtonStrMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonStrMinus.Location = new System.Drawing.Point(356, 148);
            this.ButtonStrMinus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonStrMinus.Name = "ButtonStrMinus";
            this.ButtonStrMinus.Size = new System.Drawing.Size(19, 20);
            this.ButtonStrMinus.TabIndex = 27;
            this.ButtonStrMinus.Text = "-";
            this.ButtonStrMinus.UseVisualStyleBackColor = true;
            this.ButtonStrMinus.Click += new System.EventHandler(this.ButtonStrMinus_Click);
            // 
            // labelnameSkillPoint
            // 
            this.labelnameSkillPoint.AutoSize = true;
            this.labelnameSkillPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelnameSkillPoint.Location = new System.Drawing.Point(205, 88);
            this.labelnameSkillPoint.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelnameSkillPoint.Name = "labelnameSkillPoint";
            this.labelnameSkillPoint.Size = new System.Drawing.Size(96, 20);
            this.labelnameSkillPoint.TabIndex = 26;
            this.labelnameSkillPoint.Text = "Skill points";
            // 
            // LabelSkillPoint
            // 
            this.LabelSkillPoint.AutoSize = true;
            this.LabelSkillPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelSkillPoint.Location = new System.Drawing.Point(205, 110);
            this.LabelSkillPoint.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelSkillPoint.Name = "LabelSkillPoint";
            this.LabelSkillPoint.Size = new System.Drawing.Size(18, 20);
            this.LabelSkillPoint.TabIndex = 25;
            this.LabelSkillPoint.Text = "0";
            // 
            // Create
            // 
            this.Create.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Create.Location = new System.Drawing.Point(34, 238);
            this.Create.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(87, 37);
            this.Create.TabIndex = 24;
            this.Create.Text = "Create";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // labelnameInt
            // 
            this.labelnameInt.AutoSize = true;
            this.labelnameInt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelnameInt.Location = new System.Drawing.Point(205, 209);
            this.labelnameInt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelnameInt.Name = "labelnameInt";
            this.labelnameInt.Size = new System.Drawing.Size(90, 20);
            this.labelnameInt.TabIndex = 23;
            this.labelnameInt.Text = "Intelligence";
            // 
            // labelnameCons
            // 
            this.labelnameCons.AutoSize = true;
            this.labelnameCons.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelnameCons.Location = new System.Drawing.Point(205, 188);
            this.labelnameCons.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelnameCons.Name = "labelnameCons";
            this.labelnameCons.Size = new System.Drawing.Size(94, 20);
            this.labelnameCons.TabIndex = 19;
            this.labelnameCons.Text = "Constitution";
            // 
            // labelnameDex
            // 
            this.labelnameDex.AutoSize = true;
            this.labelnameDex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelnameDex.Location = new System.Drawing.Point(205, 168);
            this.labelnameDex.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelnameDex.Name = "labelnameDex";
            this.labelnameDex.Size = new System.Drawing.Size(71, 20);
            this.labelnameDex.TabIndex = 15;
            this.labelnameDex.Text = "Dexterity";
            // 
            // labelnameStr
            // 
            this.labelnameStr.AutoSize = true;
            this.labelnameStr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelnameStr.Location = new System.Drawing.Point(205, 148);
            this.labelnameStr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelnameStr.Name = "labelnameStr";
            this.labelnameStr.Size = new System.Drawing.Size(71, 20);
            this.labelnameStr.TabIndex = 11;
            this.labelnameStr.Text = "Strength";
            // 
            // labelnameClass
            // 
            this.labelnameClass.AutoSize = true;
            this.labelnameClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelnameClass.Location = new System.Drawing.Point(30, 148);
            this.labelnameClass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelnameClass.Name = "labelnameClass";
            this.labelnameClass.Size = new System.Drawing.Size(53, 20);
            this.labelnameClass.TabIndex = 10;
            this.labelnameClass.Text = "Class";
            // 
            // labelnameNickname
            // 
            this.labelnameNickname.AutoSize = true;
            this.labelnameNickname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelnameNickname.Location = new System.Drawing.Point(30, 88);
            this.labelnameNickname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelnameNickname.Name = "labelnameNickname";
            this.labelnameNickname.Size = new System.Drawing.Size(87, 20);
            this.labelnameNickname.TabIndex = 9;
            this.labelnameNickname.Text = "Nickname";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(292, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 31);
            this.label2.TabIndex = 8;
            this.label2.Text = "Character Creation";
            // 
            // ComboBoxClass
            // 
            this.ComboBoxClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxClass.FormattingEnabled = true;
            this.ComboBoxClass.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ComboBoxClass.Items.AddRange(new object[] {
            "Warrior",
            "Rogue",
            "Wizard"});
            this.ComboBoxClass.Location = new System.Drawing.Point(34, 170);
            this.ComboBoxClass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ComboBoxClass.Name = "ComboBoxClass";
            this.ComboBoxClass.Size = new System.Drawing.Size(92, 21);
            this.ComboBoxClass.TabIndex = 7;
            this.ComboBoxClass.SelectedIndexChanged += new System.EventHandler(this.ComboBoxClass_SelectedIndexChanged);
            // 
            // TextBoxNickname
            // 
            this.TextBoxNickname.Location = new System.Drawing.Point(34, 110);
            this.TextBoxNickname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextBoxNickname.Name = "TextBoxNickname";
            this.TextBoxNickname.Size = new System.Drawing.Size(146, 20);
            this.TextBoxNickname.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 474);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TextBoxNickname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ComboBoxClass;
        private System.Windows.Forms.Label labelnameNickname;
        private System.Windows.Forms.Label labelnameStr;
        private System.Windows.Forms.Label labelnameClass;
        private System.Windows.Forms.Label labelnameInt;
        private System.Windows.Forms.Label labelnameCons;
        private System.Windows.Forms.Label labelnameDex;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Label labelnameSkillPoint;
        private System.Windows.Forms.Label LabelSkillPoint;
        private System.Windows.Forms.Button ButtonIntPlus;
        private System.Windows.Forms.Button ButtonConsPlus;
        private System.Windows.Forms.Button ButtonDexPlus;
        private System.Windows.Forms.Button ButtonStrPlus;
        private System.Windows.Forms.Label LabelInt;
        private System.Windows.Forms.Label LabelCons;
        private System.Windows.Forms.Label LabelDex;
        private System.Windows.Forms.Label LabelStr;
        private System.Windows.Forms.Button ButtonIntMinus;
        private System.Windows.Forms.Button ButtonConsMinus;
        private System.Windows.Forms.Button ButtonDexMinus;
        private System.Windows.Forms.Button ButtonStrMinus;
        private System.Windows.Forms.Label LabelDef;
        private System.Windows.Forms.Label LabelMAtt;
        private System.Windows.Forms.Label LabelAtt;
        private System.Windows.Forms.Label LabelMP;
        private System.Windows.Forms.Label LabelHP;
        private System.Windows.Forms.Label labelnameMAtt;
        private System.Windows.Forms.Label labelnameDef;
        private System.Windows.Forms.Label labelnameAtt;
        private System.Windows.Forms.Label labelnameMP;
        private System.Windows.Forms.Label labelnameHP;
        private System.Windows.Forms.ListBox ListChar;
    }
}