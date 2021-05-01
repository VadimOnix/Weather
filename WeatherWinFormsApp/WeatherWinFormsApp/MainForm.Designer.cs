namespace WeatherWinFormsApp
{
    partial class MainForm
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbNetwork = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.lbSearch = new System.Windows.Forms.Label();
            this.pnSearchBorder = new System.Windows.Forms.Panel();
            this.btnSetToday = new System.Windows.Forms.Panel();
            this.imgSetTooday = new System.Windows.Forms.Panel();
            this.lbSetToday = new System.Windows.Forms.Label();
            this.pnApp = new System.Windows.Forms.Panel();
            this.lbLastRequest = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pnMenuTab = new System.Windows.Forms.Panel();
            this.btnSetWeek = new System.Windows.Forms.Panel();
            this.imgSetWeek = new System.Windows.Forms.Panel();
            this.lbSetWeek = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Panel();
            this.pnToday = new System.Windows.Forms.Panel();
            this.lbTodayPressure = new System.Windows.Forms.Label();
            this.lbTodayHumidity = new System.Windows.Forms.Label();
            this.lbTodayWind = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbTodayTemp = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTodayLat = new System.Windows.Forms.Label();
            this.lbTodayLon = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTodayDescription = new System.Windows.Forms.Label();
            this.imgTodayStatus = new System.Windows.Forms.Panel();
            this.lbTodayCityName = new System.Windows.Forms.Label();
            this.pnWeek = new System.Windows.Forms.Panel();
            this.pnWeekDay5 = new System.Windows.Forms.Panel();
            this.lbWeekDay5Date = new System.Windows.Forms.Label();
            this.lbWeekDay5Temp = new System.Windows.Forms.Label();
            this.imgWeekDay5 = new System.Windows.Forms.Panel();
            this.pnWeekDay4 = new System.Windows.Forms.Panel();
            this.lbWeekDay4Date = new System.Windows.Forms.Label();
            this.lbWeekDay4Temp = new System.Windows.Forms.Label();
            this.imgWeekDay4 = new System.Windows.Forms.Panel();
            this.pnWeekDay3 = new System.Windows.Forms.Panel();
            this.lbWeekDay3Date = new System.Windows.Forms.Label();
            this.lbWeekDay3Temp = new System.Windows.Forms.Label();
            this.imgWeekDay3 = new System.Windows.Forms.Panel();
            this.pnWeekDay2 = new System.Windows.Forms.Panel();
            this.lbWeekDay2Date = new System.Windows.Forms.Label();
            this.lbWeekDay2Temp = new System.Windows.Forms.Label();
            this.imgWeekDay2 = new System.Windows.Forms.Panel();
            this.lbWeekCityName = new System.Windows.Forms.Label();
            this.pnWeekDay1 = new System.Windows.Forms.Panel();
            this.lbWeekDay1Date = new System.Windows.Forms.Label();
            this.lbWeekDay1Temp = new System.Windows.Forms.Label();
            this.imgWeekDay1 = new System.Windows.Forms.Panel();
            this.pnError = new System.Windows.Forms.Panel();
            this.lbError = new System.Windows.Forms.Label();
            this.imgError = new System.Windows.Forms.Panel();
            this.pnNetworkStatus = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Panel();
            this.btnSetToday.SuspendLayout();
            this.pnApp.SuspendLayout();
            this.btnSetWeek.SuspendLayout();
            this.pnToday.SuspendLayout();
            this.pnWeek.SuspendLayout();
            this.pnWeekDay5.SuspendLayout();
            this.pnWeekDay4.SuspendLayout();
            this.pnWeekDay3.SuspendLayout();
            this.pnWeekDay2.SuspendLayout();
            this.pnWeekDay1.SuspendLayout();
            this.pnError.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTitle.Location = new System.Drawing.Point(143, 56);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(629, 37);
            this.lbTitle.TabIndex = 2;
            this.lbTitle.Text = "Сервис \"Погодка\" на Open Weather Map";
            // 
            // lbNetwork
            // 
            this.lbNetwork.AutoSize = true;
            this.lbNetwork.Location = new System.Drawing.Point(909, 645);
            this.lbNetwork.Name = "lbNetwork";
            this.lbNetwork.Size = new System.Drawing.Size(176, 23);
            this.lbNetwork.TabIndex = 3;
            this.lbNetwork.Text = "Состояние сети:";
            // 
            // tbSearch
            // 
            this.tbSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.tbSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSearch.Font = new System.Drawing.Font("Century Gothic", 24F);
            this.tbSearch.ForeColor = System.Drawing.Color.White;
            this.tbSearch.Location = new System.Drawing.Point(72, 77);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(344, 50);
            this.tbSearch.TabIndex = 5;
            this.tbSearch.Enter += new System.EventHandler(this.tbSearch_Enter);
            this.tbSearch.Leave += new System.EventHandler(this.tbSearch_Leave);
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.lbSearch.Location = new System.Drawing.Point(68, 38);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(323, 30);
            this.lbSearch.TabIndex = 6;
            this.lbSearch.Text = "Введите название города";
            // 
            // pnSearchBorder
            // 
            this.pnSearchBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.pnSearchBorder.Location = new System.Drawing.Point(72, 123);
            this.pnSearchBorder.Name = "pnSearchBorder";
            this.pnSearchBorder.Size = new System.Drawing.Size(344, 2);
            this.pnSearchBorder.TabIndex = 8;
            // 
            // btnSetToday
            // 
            this.btnSetToday.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSetToday.Controls.Add(this.imgSetTooday);
            this.btnSetToday.Controls.Add(this.lbSetToday);
            this.btnSetToday.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetToday.Location = new System.Drawing.Point(72, 189);
            this.btnSetToday.Name = "btnSetToday";
            this.btnSetToday.Size = new System.Drawing.Size(232, 121);
            this.btnSetToday.TabIndex = 9;
            this.btnSetToday.Click += new System.EventHandler(this.btnSetToday_Click);
            // 
            // imgSetTooday
            // 
            this.imgSetTooday.BackColor = System.Drawing.Color.Transparent;
            this.imgSetTooday.BackgroundImage = global::WeatherWinFormsApp.Properties.Resources.today;
            this.imgSetTooday.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgSetTooday.Location = new System.Drawing.Point(79, 11);
            this.imgSetTooday.Name = "imgSetTooday";
            this.imgSetTooday.Size = new System.Drawing.Size(70, 70);
            this.imgSetTooday.TabIndex = 1;
            this.imgSetTooday.Click += new System.EventHandler(this.imgSetTooday_Click);
            // 
            // lbSetToday
            // 
            this.lbSetToday.AutoSize = true;
            this.lbSetToday.Location = new System.Drawing.Point(34, 84);
            this.lbSetToday.Name = "lbSetToday";
            this.lbSetToday.Size = new System.Drawing.Size(198, 23);
            this.lbSetToday.TabIndex = 0;
            this.lbSetToday.Text = "погода на сегодня";
            this.lbSetToday.Click += new System.EventHandler(this.lbSetToday_Click);
            // 
            // pnApp
            // 
            this.pnApp.Controls.Add(this.lbLastRequest);
            this.pnApp.Controls.Add(this.label8);
            this.pnApp.Controls.Add(this.pnMenuTab);
            this.pnApp.Controls.Add(this.btnSetWeek);
            this.pnApp.Controls.Add(this.lbSearch);
            this.pnApp.Controls.Add(this.btnSetToday);
            this.pnApp.Controls.Add(this.tbSearch);
            this.pnApp.Controls.Add(this.pnSearchBorder);
            this.pnApp.Controls.Add(this.btnSearch);
            this.pnApp.Controls.Add(this.pnWeek);
            this.pnApp.Controls.Add(this.pnToday);
            this.pnApp.Location = new System.Drawing.Point(46, 136);
            this.pnApp.Name = "pnApp";
            this.pnApp.Size = new System.Drawing.Size(1100, 488);
            this.pnApp.TabIndex = 11;
            // 
            // lbLastRequest
            // 
            this.lbLastRequest.AutoSize = true;
            this.lbLastRequest.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbLastRequest.Location = new System.Drawing.Point(881, 40);
            this.lbLastRequest.Name = "lbLastRequest";
            this.lbLastRequest.Size = new System.Drawing.Size(71, 28);
            this.lbLastRequest.TabIndex = 14;
            this.lbLastRequest.Text = "20:21";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(576, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(299, 23);
            this.label8.TabIndex = 13;
            this.label8.Text = "Время последнего запроса:";
            // 
            // pnMenuTab
            // 
            this.pnMenuTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.pnMenuTab.Location = new System.Drawing.Point(310, 189);
            this.pnMenuTab.Name = "pnMenuTab";
            this.pnMenuTab.Size = new System.Drawing.Size(8, 121);
            this.pnMenuTab.TabIndex = 13;
            // 
            // btnSetWeek
            // 
            this.btnSetWeek.Controls.Add(this.imgSetWeek);
            this.btnSetWeek.Controls.Add(this.lbSetWeek);
            this.btnSetWeek.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetWeek.Location = new System.Drawing.Point(72, 328);
            this.btnSetWeek.Name = "btnSetWeek";
            this.btnSetWeek.Size = new System.Drawing.Size(232, 121);
            this.btnSetWeek.TabIndex = 10;
            this.btnSetWeek.Click += new System.EventHandler(this.btnSetWeek_Click);
            // 
            // imgSetWeek
            // 
            this.imgSetWeek.BackColor = System.Drawing.Color.Transparent;
            this.imgSetWeek.BackgroundImage = global::WeatherWinFormsApp.Properties.Resources.calendar;
            this.imgSetWeek.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgSetWeek.Location = new System.Drawing.Point(79, 11);
            this.imgSetWeek.Name = "imgSetWeek";
            this.imgSetWeek.Size = new System.Drawing.Size(70, 70);
            this.imgSetWeek.TabIndex = 1;
            this.imgSetWeek.Click += new System.EventHandler(this.imgSetWeek_Click);
            // 
            // lbSetWeek
            // 
            this.lbSetWeek.AutoSize = true;
            this.lbSetWeek.Location = new System.Drawing.Point(44, 84);
            this.lbSetWeek.Name = "lbSetWeek";
            this.lbSetWeek.Size = new System.Drawing.Size(185, 23);
            this.lbSetWeek.TabIndex = 0;
            this.lbSetWeek.Text = "погода на 5 дней";
            this.lbSetWeek.Click += new System.EventHandler(this.lbSetWeek_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::WeatherWinFormsApp.Properties.Resources.Search_ico;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Location = new System.Drawing.Point(441, 72);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(50, 50);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pnToday
            // 
            this.pnToday.Controls.Add(this.lbTodayPressure);
            this.pnToday.Controls.Add(this.lbTodayHumidity);
            this.pnToday.Controls.Add(this.lbTodayWind);
            this.pnToday.Controls.Add(this.label5);
            this.pnToday.Controls.Add(this.label4);
            this.pnToday.Controls.Add(this.lbTodayTemp);
            this.pnToday.Controls.Add(this.label3);
            this.pnToday.Controls.Add(this.lbTodayLat);
            this.pnToday.Controls.Add(this.lbTodayLon);
            this.pnToday.Controls.Add(this.label2);
            this.pnToday.Controls.Add(this.label1);
            this.pnToday.Controls.Add(this.lbTodayDescription);
            this.pnToday.Controls.Add(this.imgTodayStatus);
            this.pnToday.Controls.Add(this.lbTodayCityName);
            this.pnToday.Location = new System.Drawing.Point(338, 187);
            this.pnToday.Name = "pnToday";
            this.pnToday.Size = new System.Drawing.Size(696, 260);
            this.pnToday.TabIndex = 11;
            // 
            // lbTodayPressure
            // 
            this.lbTodayPressure.AutoSize = true;
            this.lbTodayPressure.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTodayPressure.Location = new System.Drawing.Point(227, 217);
            this.lbTodayPressure.Name = "lbTodayPressure";
            this.lbTodayPressure.Size = new System.Drawing.Size(127, 37);
            this.lbTodayPressure.TabIndex = 13;
            this.lbTodayPressure.Text = "970 гПа";
            // 
            // lbTodayHumidity
            // 
            this.lbTodayHumidity.AutoSize = true;
            this.lbTodayHumidity.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTodayHumidity.Location = new System.Drawing.Point(227, 178);
            this.lbTodayHumidity.Name = "lbTodayHumidity";
            this.lbTodayHumidity.Size = new System.Drawing.Size(82, 37);
            this.lbTodayHumidity.TabIndex = 12;
            this.lbTodayHumidity.Text = "67 %";
            // 
            // lbTodayWind
            // 
            this.lbTodayWind.AutoSize = true;
            this.lbTodayWind.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTodayWind.Location = new System.Drawing.Point(227, 139);
            this.lbTodayWind.Name = "lbTodayWind";
            this.lbTodayWind.Size = new System.Drawing.Size(260, 37);
            this.lbTodayWind.TabIndex = 11;
            this.lbTodayWind.Text = "Северный 2 м/c";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(43, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 37);
            this.label5.TabIndex = 10;
            this.label5.Text = "Давление:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(43, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 37);
            this.label4.TabIndex = 9;
            this.label4.Text = "Влажность:";
            // 
            // lbTodayTemp
            // 
            this.lbTodayTemp.AutoSize = true;
            this.lbTodayTemp.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTodayTemp.Location = new System.Drawing.Point(536, 23);
            this.lbTodayTemp.Name = "lbTodayTemp";
            this.lbTodayTemp.Size = new System.Drawing.Size(100, 70);
            this.lbTodayTemp.TabIndex = 8;
            this.lbTodayTemp.Text = "+8";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(43, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 37);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ветер:";
            // 
            // lbTodayLat
            // 
            this.lbTodayLat.AutoSize = true;
            this.lbTodayLat.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTodayLat.Location = new System.Drawing.Point(623, 223);
            this.lbTodayLat.Name = "lbTodayLat";
            this.lbTodayLat.Size = new System.Drawing.Size(60, 23);
            this.lbTodayLat.TabIndex = 6;
            this.lbTodayLat.Text = "63.57";
            // 
            // lbTodayLon
            // 
            this.lbTodayLon.AutoSize = true;
            this.lbTodayLon.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTodayLon.Location = new System.Drawing.Point(623, 188);
            this.lbTodayLon.Name = "lbTodayLon";
            this.lbTodayLon.Size = new System.Drawing.Size(60, 23);
            this.lbTodayLon.TabIndex = 5;
            this.lbTodayLon.Text = "53.68";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(544, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Долгота:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(544, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Широта:";
            // 
            // lbTodayDescription
            // 
            this.lbTodayDescription.AutoSize = true;
            this.lbTodayDescription.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTodayDescription.Location = new System.Drawing.Point(163, 93);
            this.lbTodayDescription.Name = "lbTodayDescription";
            this.lbTodayDescription.Size = new System.Drawing.Size(394, 37);
            this.lbTodayDescription.TabIndex = 2;
            this.lbTodayDescription.Text = "Облачно с прояснением";
            // 
            // imgTodayStatus
            // 
            this.imgTodayStatus.BackgroundImage = global::WeatherWinFormsApp.Properties.Resources.sun;
            this.imgTodayStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgTodayStatus.Location = new System.Drawing.Point(43, 21);
            this.imgTodayStatus.Name = "imgTodayStatus";
            this.imgTodayStatus.Size = new System.Drawing.Size(100, 100);
            this.imgTodayStatus.TabIndex = 1;
            // 
            // lbTodayCityName
            // 
            this.lbTodayCityName.AutoSize = true;
            this.lbTodayCityName.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTodayCityName.Location = new System.Drawing.Point(158, 21);
            this.lbTodayCityName.Name = "lbTodayCityName";
            this.lbTodayCityName.Size = new System.Drawing.Size(174, 70);
            this.lbTodayCityName.TabIndex = 0;
            this.lbTodayCityName.Text = "Ухта";
            // 
            // pnWeek
            // 
            this.pnWeek.Controls.Add(this.pnWeekDay5);
            this.pnWeek.Controls.Add(this.pnWeekDay4);
            this.pnWeek.Controls.Add(this.pnWeekDay3);
            this.pnWeek.Controls.Add(this.pnWeekDay2);
            this.pnWeek.Controls.Add(this.lbWeekCityName);
            this.pnWeek.Controls.Add(this.pnWeekDay1);
            this.pnWeek.Location = new System.Drawing.Point(344, 190);
            this.pnWeek.Name = "pnWeek";
            this.pnWeek.Size = new System.Drawing.Size(695, 260);
            this.pnWeek.TabIndex = 12;
            // 
            // pnWeekDay5
            // 
            this.pnWeekDay5.Controls.Add(this.lbWeekDay5Date);
            this.pnWeekDay5.Controls.Add(this.lbWeekDay5Temp);
            this.pnWeekDay5.Controls.Add(this.imgWeekDay5);
            this.pnWeekDay5.Location = new System.Drawing.Point(559, 93);
            this.pnWeekDay5.Name = "pnWeekDay5";
            this.pnWeekDay5.Size = new System.Drawing.Size(133, 151);
            this.pnWeekDay5.TabIndex = 2;
            // 
            // lbWeekDay5Date
            // 
            this.lbWeekDay5Date.AutoSize = true;
            this.lbWeekDay5Date.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbWeekDay5Date.Location = new System.Drawing.Point(17, 120);
            this.lbWeekDay5Date.Name = "lbWeekDay5Date";
            this.lbWeekDay5Date.Size = new System.Drawing.Size(114, 23);
            this.lbWeekDay5Date.TabIndex = 1;
            this.lbWeekDay5Date.Text = "2020-05-23";
            // 
            // lbWeekDay5Temp
            // 
            this.lbWeekDay5Temp.AutoSize = true;
            this.lbWeekDay5Temp.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbWeekDay5Temp.Location = new System.Drawing.Point(34, 84);
            this.lbWeekDay5Temp.MinimumSize = new System.Drawing.Size(60, 0);
            this.lbWeekDay5Temp.Name = "lbWeekDay5Temp";
            this.lbWeekDay5Temp.Size = new System.Drawing.Size(60, 32);
            this.lbWeekDay5Temp.TabIndex = 0;
            this.lbWeekDay5Temp.Text = "-25";
            this.lbWeekDay5Temp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imgWeekDay5
            // 
            this.imgWeekDay5.BackgroundImage = global::WeatherWinFormsApp.Properties.Resources.penguin;
            this.imgWeekDay5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgWeekDay5.Location = new System.Drawing.Point(34, 13);
            this.imgWeekDay5.Name = "imgWeekDay5";
            this.imgWeekDay5.Size = new System.Drawing.Size(60, 60);
            this.imgWeekDay5.TabIndex = 0;
            // 
            // pnWeekDay4
            // 
            this.pnWeekDay4.Controls.Add(this.lbWeekDay4Date);
            this.pnWeekDay4.Controls.Add(this.lbWeekDay4Temp);
            this.pnWeekDay4.Controls.Add(this.imgWeekDay4);
            this.pnWeekDay4.Location = new System.Drawing.Point(420, 93);
            this.pnWeekDay4.Name = "pnWeekDay4";
            this.pnWeekDay4.Size = new System.Drawing.Size(133, 151);
            this.pnWeekDay4.TabIndex = 2;
            // 
            // lbWeekDay4Date
            // 
            this.lbWeekDay4Date.AutoSize = true;
            this.lbWeekDay4Date.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbWeekDay4Date.Location = new System.Drawing.Point(17, 120);
            this.lbWeekDay4Date.Name = "lbWeekDay4Date";
            this.lbWeekDay4Date.Size = new System.Drawing.Size(114, 23);
            this.lbWeekDay4Date.TabIndex = 1;
            this.lbWeekDay4Date.Text = "2020-05-22";
            // 
            // lbWeekDay4Temp
            // 
            this.lbWeekDay4Temp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbWeekDay4Temp.AutoSize = true;
            this.lbWeekDay4Temp.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbWeekDay4Temp.Location = new System.Drawing.Point(34, 84);
            this.lbWeekDay4Temp.MinimumSize = new System.Drawing.Size(60, 0);
            this.lbWeekDay4Temp.Name = "lbWeekDay4Temp";
            this.lbWeekDay4Temp.Size = new System.Drawing.Size(61, 32);
            this.lbWeekDay4Temp.TabIndex = 0;
            this.lbWeekDay4Temp.Text = "+15";
            this.lbWeekDay4Temp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imgWeekDay4
            // 
            this.imgWeekDay4.BackgroundImage = global::WeatherWinFormsApp.Properties.Resources.lightening;
            this.imgWeekDay4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgWeekDay4.Location = new System.Drawing.Point(34, 13);
            this.imgWeekDay4.Name = "imgWeekDay4";
            this.imgWeekDay4.Size = new System.Drawing.Size(60, 60);
            this.imgWeekDay4.TabIndex = 0;
            // 
            // pnWeekDay3
            // 
            this.pnWeekDay3.Controls.Add(this.lbWeekDay3Date);
            this.pnWeekDay3.Controls.Add(this.lbWeekDay3Temp);
            this.pnWeekDay3.Controls.Add(this.imgWeekDay3);
            this.pnWeekDay3.Location = new System.Drawing.Point(281, 93);
            this.pnWeekDay3.Name = "pnWeekDay3";
            this.pnWeekDay3.Size = new System.Drawing.Size(133, 151);
            this.pnWeekDay3.TabIndex = 2;
            // 
            // lbWeekDay3Date
            // 
            this.lbWeekDay3Date.AutoSize = true;
            this.lbWeekDay3Date.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbWeekDay3Date.Location = new System.Drawing.Point(17, 120);
            this.lbWeekDay3Date.Name = "lbWeekDay3Date";
            this.lbWeekDay3Date.Size = new System.Drawing.Size(114, 23);
            this.lbWeekDay3Date.TabIndex = 1;
            this.lbWeekDay3Date.Text = "2020-05-21";
            // 
            // lbWeekDay3Temp
            // 
            this.lbWeekDay3Temp.AutoSize = true;
            this.lbWeekDay3Temp.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbWeekDay3Temp.Location = new System.Drawing.Point(34, 84);
            this.lbWeekDay3Temp.MinimumSize = new System.Drawing.Size(60, 0);
            this.lbWeekDay3Temp.Name = "lbWeekDay3Temp";
            this.lbWeekDay3Temp.Size = new System.Drawing.Size(61, 32);
            this.lbWeekDay3Temp.TabIndex = 0;
            this.lbWeekDay3Temp.Text = "+12";
            this.lbWeekDay3Temp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imgWeekDay3
            // 
            this.imgWeekDay3.BackgroundImage = global::WeatherWinFormsApp.Properties.Resources.tornado;
            this.imgWeekDay3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgWeekDay3.Location = new System.Drawing.Point(34, 13);
            this.imgWeekDay3.Name = "imgWeekDay3";
            this.imgWeekDay3.Size = new System.Drawing.Size(60, 60);
            this.imgWeekDay3.TabIndex = 0;
            // 
            // pnWeekDay2
            // 
            this.pnWeekDay2.Controls.Add(this.lbWeekDay2Date);
            this.pnWeekDay2.Controls.Add(this.lbWeekDay2Temp);
            this.pnWeekDay2.Controls.Add(this.imgWeekDay2);
            this.pnWeekDay2.Location = new System.Drawing.Point(142, 93);
            this.pnWeekDay2.Name = "pnWeekDay2";
            this.pnWeekDay2.Size = new System.Drawing.Size(133, 151);
            this.pnWeekDay2.TabIndex = 2;
            // 
            // lbWeekDay2Date
            // 
            this.lbWeekDay2Date.AutoSize = true;
            this.lbWeekDay2Date.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbWeekDay2Date.Location = new System.Drawing.Point(17, 120);
            this.lbWeekDay2Date.Name = "lbWeekDay2Date";
            this.lbWeekDay2Date.Size = new System.Drawing.Size(114, 23);
            this.lbWeekDay2Date.TabIndex = 1;
            this.lbWeekDay2Date.Text = "2020-05-20";
            // 
            // lbWeekDay2Temp
            // 
            this.lbWeekDay2Temp.AutoSize = true;
            this.lbWeekDay2Temp.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbWeekDay2Temp.Location = new System.Drawing.Point(34, 84);
            this.lbWeekDay2Temp.MinimumSize = new System.Drawing.Size(60, 0);
            this.lbWeekDay2Temp.Name = "lbWeekDay2Temp";
            this.lbWeekDay2Temp.Size = new System.Drawing.Size(60, 32);
            this.lbWeekDay2Temp.TabIndex = 0;
            this.lbWeekDay2Temp.Text = "+2";
            this.lbWeekDay2Temp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imgWeekDay2
            // 
            this.imgWeekDay2.BackgroundImage = global::WeatherWinFormsApp.Properties.Resources.umbrella;
            this.imgWeekDay2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgWeekDay2.Location = new System.Drawing.Point(34, 13);
            this.imgWeekDay2.Name = "imgWeekDay2";
            this.imgWeekDay2.Size = new System.Drawing.Size(60, 60);
            this.imgWeekDay2.TabIndex = 0;
            // 
            // lbWeekCityName
            // 
            this.lbWeekCityName.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbWeekCityName.Location = new System.Drawing.Point(3, 20);
            this.lbWeekCityName.Name = "lbWeekCityName";
            this.lbWeekCityName.Size = new System.Drawing.Size(692, 70);
            this.lbWeekCityName.TabIndex = 1;
            this.lbWeekCityName.Text = "Ухта";
            this.lbWeekCityName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnWeekDay1
            // 
            this.pnWeekDay1.Controls.Add(this.lbWeekDay1Date);
            this.pnWeekDay1.Controls.Add(this.lbWeekDay1Temp);
            this.pnWeekDay1.Controls.Add(this.imgWeekDay1);
            this.pnWeekDay1.Location = new System.Drawing.Point(3, 93);
            this.pnWeekDay1.Name = "pnWeekDay1";
            this.pnWeekDay1.Size = new System.Drawing.Size(133, 151);
            this.pnWeekDay1.TabIndex = 0;
            // 
            // lbWeekDay1Date
            // 
            this.lbWeekDay1Date.AutoSize = true;
            this.lbWeekDay1Date.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbWeekDay1Date.Location = new System.Drawing.Point(17, 120);
            this.lbWeekDay1Date.Name = "lbWeekDay1Date";
            this.lbWeekDay1Date.Size = new System.Drawing.Size(114, 23);
            this.lbWeekDay1Date.TabIndex = 1;
            this.lbWeekDay1Date.Text = "2020-05-19";
            // 
            // lbWeekDay1Temp
            // 
            this.lbWeekDay1Temp.AutoSize = true;
            this.lbWeekDay1Temp.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbWeekDay1Temp.Location = new System.Drawing.Point(34, 84);
            this.lbWeekDay1Temp.MinimumSize = new System.Drawing.Size(60, 0);
            this.lbWeekDay1Temp.Name = "lbWeekDay1Temp";
            this.lbWeekDay1Temp.Size = new System.Drawing.Size(60, 32);
            this.lbWeekDay1Temp.TabIndex = 0;
            this.lbWeekDay1Temp.Text = "+8";
            this.lbWeekDay1Temp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imgWeekDay1
            // 
            this.imgWeekDay1.BackgroundImage = global::WeatherWinFormsApp.Properties.Resources.sun;
            this.imgWeekDay1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgWeekDay1.Location = new System.Drawing.Point(34, 13);
            this.imgWeekDay1.Name = "imgWeekDay1";
            this.imgWeekDay1.Size = new System.Drawing.Size(60, 60);
            this.imgWeekDay1.TabIndex = 0;
            // 
            // pnError
            // 
            this.pnError.Controls.Add(this.lbError);
            this.pnError.Controls.Add(this.imgError);
            this.pnError.Location = new System.Drawing.Point(34, 124);
            this.pnError.Name = "pnError";
            this.pnError.Size = new System.Drawing.Size(1126, 510);
            this.pnError.TabIndex = 12;
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold);
            this.lbError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.lbError.Location = new System.Drawing.Point(75, 331);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(1212, 140);
            this.lbError.TabIndex = 1;
            this.lbError.Text = "Ой-ой-ой!\r\nПроверьте соединение с интернетом!";
            this.lbError.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // imgError
            // 
            this.imgError.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imgError.BackgroundImage = global::WeatherWinFormsApp.Properties.Resources.грустный_png_2;
            this.imgError.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgError.Location = new System.Drawing.Point(422, 67);
            this.imgError.Name = "imgError";
            this.imgError.Size = new System.Drawing.Size(285, 254);
            this.imgError.TabIndex = 0;
            // 
            // pnNetworkStatus
            // 
            this.pnNetworkStatus.BackgroundImage = global::WeatherWinFormsApp.Properties.Resources.good_network;
            this.pnNetworkStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnNetworkStatus.Location = new System.Drawing.Point(1096, 630);
            this.pnNetworkStatus.Name = "pnNetworkStatus";
            this.pnNetworkStatus.Size = new System.Drawing.Size(50, 50);
            this.pnNetworkStatus.TabIndex = 4;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.Transparent;
            this.panelLogo.BackgroundImage = global::WeatherWinFormsApp.Properties.Resources.celsius;
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelLogo.Location = new System.Drawing.Point(46, 35);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(70, 70);
            this.panelLogo.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = global::WeatherWinFormsApp.Properties.Resources.close_red;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.ForeColor = System.Drawing.Color.Transparent;
            this.btnClose.Location = new System.Drawing.Point(1096, 45);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 50);
            this.btnClose.TabIndex = 1;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.pnNetworkStatus);
            this.Controls.Add(this.lbNetwork);
            this.Controls.Add(this.panelLogo);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pnApp);
            this.Controls.Add(this.pnError);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Погода";
            this.btnSetToday.ResumeLayout(false);
            this.btnSetToday.PerformLayout();
            this.pnApp.ResumeLayout(false);
            this.pnApp.PerformLayout();
            this.btnSetWeek.ResumeLayout(false);
            this.btnSetWeek.PerformLayout();
            this.pnToday.ResumeLayout(false);
            this.pnToday.PerformLayout();
            this.pnWeek.ResumeLayout(false);
            this.pnWeekDay5.ResumeLayout(false);
            this.pnWeekDay5.PerformLayout();
            this.pnWeekDay4.ResumeLayout(false);
            this.pnWeekDay4.PerformLayout();
            this.pnWeekDay3.ResumeLayout(false);
            this.pnWeekDay3.PerformLayout();
            this.pnWeekDay2.ResumeLayout(false);
            this.pnWeekDay2.PerformLayout();
            this.pnWeekDay1.ResumeLayout(false);
            this.pnWeekDay1.PerformLayout();
            this.pnError.ResumeLayout(false);
            this.pnError.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel btnClose;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label lbNetwork;
        private System.Windows.Forms.Panel pnNetworkStatus;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.Panel btnSearch;
        private System.Windows.Forms.Panel pnSearchBorder;
        private System.Windows.Forms.Panel btnSetToday;
        private System.Windows.Forms.Panel imgSetTooday;
        private System.Windows.Forms.Label lbSetToday;
        private System.Windows.Forms.Panel pnApp;
        private System.Windows.Forms.Panel btnSetWeek;
        private System.Windows.Forms.Panel imgSetWeek;
        private System.Windows.Forms.Label lbSetWeek;
        private System.Windows.Forms.Panel pnError;
        private System.Windows.Forms.Label lbError;
        private System.Windows.Forms.Panel imgError;
        private System.Windows.Forms.Panel pnWeek;
        private System.Windows.Forms.Panel pnToday;
        private System.Windows.Forms.Panel pnMenuTab;
        private System.Windows.Forms.Panel imgTodayStatus;
        private System.Windows.Forms.Label lbTodayCityName;
        private System.Windows.Forms.Label lbTodayLat;
        private System.Windows.Forms.Label lbTodayLon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTodayDescription;
        private System.Windows.Forms.Label lbTodayTemp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbTodayPressure;
        private System.Windows.Forms.Label lbTodayHumidity;
        private System.Windows.Forms.Label lbTodayWind;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbWeekCityName;
        private System.Windows.Forms.Panel pnWeekDay1;
        private System.Windows.Forms.Label lbWeekDay1Date;
        private System.Windows.Forms.Label lbWeekDay1Temp;
        private System.Windows.Forms.Panel imgWeekDay1;
        private System.Windows.Forms.Panel pnWeekDay5;
        private System.Windows.Forms.Label lbWeekDay5Date;
        private System.Windows.Forms.Label lbWeekDay5Temp;
        private System.Windows.Forms.Panel imgWeekDay5;
        private System.Windows.Forms.Panel pnWeekDay4;
        private System.Windows.Forms.Label lbWeekDay4Date;
        private System.Windows.Forms.Label lbWeekDay4Temp;
        private System.Windows.Forms.Panel imgWeekDay4;
        private System.Windows.Forms.Panel pnWeekDay3;
        private System.Windows.Forms.Label lbWeekDay3Date;
        private System.Windows.Forms.Label lbWeekDay3Temp;
        private System.Windows.Forms.Panel imgWeekDay3;
        private System.Windows.Forms.Panel pnWeekDay2;
        private System.Windows.Forms.Label lbWeekDay2Date;
        private System.Windows.Forms.Label lbWeekDay2Temp;
        private System.Windows.Forms.Panel imgWeekDay2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbLastRequest;
    }
}

