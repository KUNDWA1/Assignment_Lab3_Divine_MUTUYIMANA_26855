namespace Lab3Assignment.Views
{
    partial class VendorForm
    {
        
        private System.ComponentModel.IContainer components = null;

        
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        private void InitializeComponent()
        {
            mainContainer = new Panel();
            profileView = new Panel();
            page = new FlowLayoutPanel();
            hero = new FlowLayoutPanel();
            avatar = new Panel();
            heroText = new FlowLayoutPanel();
            lblTitle = new Label();
            lblSubTitle = new Label();
            lblPill = new Label();
            statsRow = new FlowLayoutPanel();
            cardStatTotal = new FlowLayoutPanel();
            lblStatTotal = new Label();
            lblStatTotalCaption = new Label();
            cardStatPending = new FlowLayoutPanel();
            lblStatPending = new Label();
            lblStatPendingCaption = new Label();
            cardStatAccepted = new FlowLayoutPanel();
            lblStatAccepted = new Label();
            lblStatAcceptedCaption = new Label();
            details = new FlowLayoutPanel();
            lblDetailsTitle = new Label();
            lblDetailsHint = new Label();
            row1 = new FlowLayoutPanel();
            stackName = new FlowLayoutPanel();
            lblName = new Label();
            txtName = new TextBox();
            stackService = new FlowLayoutPanel();
            lblService = new Label();
            txtService = new TextBox();
            row2 = new FlowLayoutPanel();
            stackPriceMin = new FlowLayoutPanel();
            lblPriceMin = new Label();
            txtPriceMin = new TextBox();
            stackPriceMax = new FlowLayoutPanel();
            lblPriceMax = new Label();
            txtPriceMax = new TextBox();
            row3 = new FlowLayoutPanel();
            stackLocation = new FlowLayoutPanel();
            lblLocation = new Label();
            txtLocation = new TextBox();
            btnRow = new FlowLayoutPanel();
            btnEditSave = new Button();
            btnCancel = new Button();
            bookingsView = new Panel();
            bkRoot = new TableLayoutPanel();
            bkListCard = new Panel();
            gridBookings = new DataGridView();
            lblBookingsTitle = new Label();
            bkDetailCard = new Panel();
            bkDetail = new TableLayoutPanel();
            lblBkEvent = new Label();
            lblBkInfo = new Label();
            lblBkStatus = new Label();
            lblBkMsgCaption = new Label();
            txtBkMessage = new TextBox();
            lblBkRespCaption = new Label();
            txtBkResponse = new TextBox();
            actions = new TableLayoutPanel();
            btnAccept = new Button();
            btnReject = new Button();
            header = new Panel();
            lblUser = new Label();
            lblHeaderTitle = new Label();
            headerLine = new Panel();
            sidebar = new Panel();
            btnProfile = new Button();
            btnBookings = new Button();
            btnLogout = new Button();
            logo = new Label();
            mainContainer.SuspendLayout();
            profileView.SuspendLayout();
            page.SuspendLayout();
            hero.SuspendLayout();
            heroText.SuspendLayout();
            statsRow.SuspendLayout();
            cardStatTotal.SuspendLayout();
            cardStatPending.SuspendLayout();
            cardStatAccepted.SuspendLayout();
            details.SuspendLayout();
            row1.SuspendLayout();
            stackName.SuspendLayout();
            stackService.SuspendLayout();
            row2.SuspendLayout();
            stackPriceMin.SuspendLayout();
            stackPriceMax.SuspendLayout();
            row3.SuspendLayout();
            stackLocation.SuspendLayout();
            btnRow.SuspendLayout();
            bookingsView.SuspendLayout();
            bkRoot.SuspendLayout();
            bkListCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridBookings).BeginInit();
            bkDetailCard.SuspendLayout();
            bkDetail.SuspendLayout();
            actions.SuspendLayout();
            header.SuspendLayout();
            sidebar.SuspendLayout();
            SuspendLayout();
            // 
            // mainContainer
            // 
            mainContainer.BackColor = Color.FromArgb(244, 246, 249);
            mainContainer.Controls.Add(profileView);
            mainContainer.Controls.Add(bookingsView);
            mainContainer.Dock = DockStyle.Fill;
            mainContainer.Location = new Point(250, 76);
            mainContainer.Name = "mainContainer";
            mainContainer.Padding = new Padding(30);
            mainContainer.Size = new Size(928, 628);
            mainContainer.TabIndex = 0;
            // 
            // profileView
            // 
            profileView.AutoScroll = true;
            profileView.BackColor = Color.Transparent;
            profileView.Controls.Add(page);
            profileView.Dock = DockStyle.Fill;
            profileView.Location = new Point(30, 30);
            profileView.Name = "profileView";
            profileView.Size = new Size(868, 568);
            profileView.TabIndex = 0;
            profileView.Visible = false;
            profileView.Resize += profileView_Resize;
            // 
            // page
            // 
            page.AutoSize = true;
            page.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            page.BackColor = Color.Transparent;
            page.Controls.Add(hero);
            page.Controls.Add(statsRow);
            page.Controls.Add(details);
            page.FlowDirection = FlowDirection.TopDown;
            page.Location = new Point(0, 0);
            page.Margin = new Padding(0);
            page.Name = "page";
            page.Size = new Size(760, 783);
            page.TabIndex = 0;
            page.WrapContents = false;
            page.SizeChanged += page_SizeChanged;
            // 
            // hero
            // 
            hero.AutoSize = true;
            hero.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            hero.BackColor = Color.FromArgb(61, 76, 155);
            hero.Controls.Add(avatar);
            hero.Controls.Add(heroText);
            hero.Location = new Point(0, 0);
            hero.Margin = new Padding(0, 0, 0, 16);
            hero.MinimumSize = new Size(760, 0);
            hero.Name = "hero";
            hero.Padding = new Padding(28);
            hero.Size = new Size(760, 185);
            hero.TabIndex = 0;
            hero.WrapContents = false;
            // 
            // avatar
            // 
            avatar.BackColor = Color.FromArgb(61, 76, 155);
            avatar.Location = new Point(28, 28);
            avatar.Margin = new Padding(0, 0, 22, 0);
            avatar.Name = "avatar";
            avatar.Size = new Size(140, 129);
            avatar.TabIndex = 0;
            avatar.Paint += avatar_Paint;
            // 
            // heroText
            // 
            heroText.AutoSize = true;
            heroText.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            heroText.BackColor = Color.FromArgb(61, 76, 155);
            heroText.Controls.Add(lblTitle);
            heroText.Controls.Add(lblSubTitle);
            heroText.Controls.Add(lblPill);
            heroText.FlowDirection = FlowDirection.TopDown;
            heroText.Location = new Point(190, 28);
            heroText.Margin = new Padding(0);
            heroText.Name = "heroText";
            heroText.Size = new Size(412, 129);
            heroText.TabIndex = 1;
            heroText.WrapContents = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Margin = new Padding(0);
            lblTitle.MaximumSize = new Size(560, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(318, 54);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Business Profile";
            // 
            // lblSubTitle
            // 
            lblSubTitle.AutoSize = true;
            lblSubTitle.Font = new Font("Segoe UI", 10.5F);
            lblSubTitle.ForeColor = Color.FromArgb(205, 212, 240);
            lblSubTitle.Location = new Point(2, 56);
            lblSubTitle.Margin = new Padding(2, 2, 0, 10);
            lblSubTitle.MaximumSize = new Size(560, 0);
            lblSubTitle.Name = "lblSubTitle";
            lblSubTitle.Size = new Size(410, 30);
            lblSubTitle.TabIndex = 1;
            lblSubTitle.Text = "Catering  •  Kigali  •  50,000 – 150,000 RWF";
            // 
            // lblPill
            // 
            lblPill.AutoSize = true;
            lblPill.BackColor = Color.FromArgb(40, 160, 90);
            lblPill.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPill.ForeColor = Color.White;
            lblPill.Location = new Point(0, 96);
            lblPill.Margin = new Padding(0);
            lblPill.MaximumSize = new Size(560, 0);
            lblPill.Name = "lblPill";
            lblPill.Padding = new Padding(12, 4, 12, 4);
            lblPill.Size = new Size(148, 33);
            lblPill.TabIndex = 2;
            lblPill.Text = "●  Profile live";
            // 
            // statsRow
            // 
            statsRow.AutoSize = true;
            statsRow.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            statsRow.BackColor = Color.Transparent;
            statsRow.Controls.Add(cardStatTotal);
            statsRow.Controls.Add(cardStatPending);
            statsRow.Controls.Add(cardStatAccepted);
            statsRow.Location = new Point(0, 201);
            statsRow.Margin = new Padding(0, 0, 0, 16);
            statsRow.MinimumSize = new Size(760, 0);
            statsRow.Name = "statsRow";
            statsRow.Size = new Size(760, 117);
            statsRow.TabIndex = 1;
            statsRow.Visible = false;
            statsRow.WrapContents = false;
            // 
            // cardStatTotal
            // 
            cardStatTotal.AutoSize = true;
            cardStatTotal.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            cardStatTotal.BackColor = Color.White;
            cardStatTotal.Controls.Add(lblStatTotal);
            cardStatTotal.Controls.Add(lblStatTotalCaption);
            cardStatTotal.FlowDirection = FlowDirection.TopDown;
            cardStatTotal.Location = new Point(0, 0);
            cardStatTotal.Margin = new Padding(0, 0, 12, 0);
            cardStatTotal.MinimumSize = new Size(245, 0);
            cardStatTotal.Name = "cardStatTotal";
            cardStatTotal.Padding = new Padding(20, 16, 20, 16);
            cardStatTotal.Size = new Size(245, 117);
            cardStatTotal.TabIndex = 0;
            cardStatTotal.WrapContents = false;
            cardStatTotal.Paint += Card_Paint;
            // 
            // lblStatTotal
            // 
            lblStatTotal.AutoSize = true;
            lblStatTotal.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblStatTotal.ForeColor = Color.FromArgb(61, 76, 155);
            lblStatTotal.Location = new Point(20, 16);
            lblStatTotal.Margin = new Padding(0);
            lblStatTotal.Name = "lblStatTotal";
            lblStatTotal.Size = new Size(50, 60);
            lblStatTotal.TabIndex = 0;
            lblStatTotal.Text = "0";
            // 
            // lblStatTotalCaption
            // 
            lblStatTotalCaption.AutoSize = true;
            lblStatTotalCaption.Font = new Font("Segoe UI", 9.5F);
            lblStatTotalCaption.ForeColor = Color.Gray;
            lblStatTotalCaption.Location = new Point(22, 76);
            lblStatTotalCaption.Margin = new Padding(2, 0, 0, 0);
            lblStatTotalCaption.Name = "lblStatTotalCaption";
            lblStatTotalCaption.Size = new Size(128, 25);
            lblStatTotalCaption.TabIndex = 1;
            lblStatTotalCaption.Text = "Total requests";
            // 
            // cardStatPending
            // 
            cardStatPending.AutoSize = true;
            cardStatPending.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            cardStatPending.BackColor = Color.White;
            cardStatPending.Controls.Add(lblStatPending);
            cardStatPending.Controls.Add(lblStatPendingCaption);
            cardStatPending.FlowDirection = FlowDirection.TopDown;
            cardStatPending.Location = new Point(257, 0);
            cardStatPending.Margin = new Padding(0, 0, 12, 0);
            cardStatPending.MinimumSize = new Size(245, 0);
            cardStatPending.Name = "cardStatPending";
            cardStatPending.Padding = new Padding(20, 16, 20, 16);
            cardStatPending.Size = new Size(245, 117);
            cardStatPending.TabIndex = 1;
            cardStatPending.WrapContents = false;
            cardStatPending.Paint += Card_Paint;
            // 
            // lblStatPending
            // 
            lblStatPending.AutoSize = true;
            lblStatPending.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblStatPending.ForeColor = Color.FromArgb(61, 76, 155);
            lblStatPending.Location = new Point(20, 16);
            lblStatPending.Margin = new Padding(0);
            lblStatPending.Name = "lblStatPending";
            lblStatPending.Size = new Size(50, 60);
            lblStatPending.TabIndex = 0;
            lblStatPending.Text = "0";
            // 
            // lblStatPendingCaption
            // 
            lblStatPendingCaption.AutoSize = true;
            lblStatPendingCaption.Font = new Font("Segoe UI", 9.5F);
            lblStatPendingCaption.ForeColor = Color.Gray;
            lblStatPendingCaption.Location = new Point(22, 76);
            lblStatPendingCaption.Margin = new Padding(2, 0, 0, 0);
            lblStatPendingCaption.Name = "lblStatPendingCaption";
            lblStatPendingCaption.Size = new Size(81, 25);
            lblStatPendingCaption.TabIndex = 1;
            lblStatPendingCaption.Text = "Pending";
            // 
            // cardStatAccepted
            // 
            cardStatAccepted.AutoSize = true;
            cardStatAccepted.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            cardStatAccepted.BackColor = Color.White;
            cardStatAccepted.Controls.Add(lblStatAccepted);
            cardStatAccepted.Controls.Add(lblStatAcceptedCaption);
            cardStatAccepted.FlowDirection = FlowDirection.TopDown;
            cardStatAccepted.Location = new Point(514, 0);
            cardStatAccepted.Margin = new Padding(0);
            cardStatAccepted.MinimumSize = new Size(246, 0);
            cardStatAccepted.Name = "cardStatAccepted";
            cardStatAccepted.Padding = new Padding(20, 16, 20, 16);
            cardStatAccepted.Size = new Size(246, 117);
            cardStatAccepted.TabIndex = 2;
            cardStatAccepted.WrapContents = false;
            cardStatAccepted.Paint += Card_Paint;
            // 
            // lblStatAccepted
            // 
            lblStatAccepted.AutoSize = true;
            lblStatAccepted.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblStatAccepted.ForeColor = Color.FromArgb(61, 76, 155);
            lblStatAccepted.Location = new Point(20, 16);
            lblStatAccepted.Margin = new Padding(0);
            lblStatAccepted.Name = "lblStatAccepted";
            lblStatAccepted.Size = new Size(50, 60);
            lblStatAccepted.TabIndex = 0;
            lblStatAccepted.Text = "0";
            // 
            // lblStatAcceptedCaption
            // 
            lblStatAcceptedCaption.AutoSize = true;
            lblStatAcceptedCaption.Font = new Font("Segoe UI", 9.5F);
            lblStatAcceptedCaption.ForeColor = Color.Gray;
            lblStatAcceptedCaption.Location = new Point(22, 76);
            lblStatAcceptedCaption.Margin = new Padding(2, 0, 0, 0);
            lblStatAcceptedCaption.Name = "lblStatAcceptedCaption";
            lblStatAcceptedCaption.Size = new Size(90, 25);
            lblStatAcceptedCaption.TabIndex = 1;
            lblStatAcceptedCaption.Text = "Accepted";
            // 
            // details
            // 
            details.AutoSize = true;
            details.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            details.BackColor = Color.White;
            details.Controls.Add(lblDetailsTitle);
            details.Controls.Add(lblDetailsHint);
            details.Controls.Add(row1);
            details.Controls.Add(row2);
            details.Controls.Add(row3);
            details.Controls.Add(btnRow);
            details.FlowDirection = FlowDirection.TopDown;
            details.Location = new Point(0, 334);
            details.Margin = new Padding(0);
            details.MinimumSize = new Size(760, 0);
            details.Name = "details";
            details.Padding = new Padding(28);
            details.Size = new Size(760, 449);
            details.TabIndex = 2;
            details.WrapContents = false;
            details.Paint += Card_Paint;
            // 
            // lblDetailsTitle
            // 
            lblDetailsTitle.AutoSize = true;
            lblDetailsTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblDetailsTitle.ForeColor = Color.FromArgb(40, 44, 70);
            lblDetailsTitle.Location = new Point(28, 28);
            lblDetailsTitle.Margin = new Padding(0, 0, 0, 2);
            lblDetailsTitle.Name = "lblDetailsTitle";
            lblDetailsTitle.Size = new Size(226, 38);
            lblDetailsTitle.TabIndex = 0;
            lblDetailsTitle.Text = "Business Details";
            // 
            // lblDetailsHint
            // 
            lblDetailsHint.AutoSize = true;
            lblDetailsHint.Font = new Font("Segoe UI", 9.5F);
            lblDetailsHint.ForeColor = Color.Gray;
            lblDetailsHint.Location = new Point(30, 68);
            lblDetailsHint.Margin = new Padding(2, 0, 0, 20);
            lblDetailsHint.MaximumSize = new Size(704, 0);
            lblDetailsHint.Name = "lblDetailsHint";
            lblDetailsHint.Size = new Size(368, 25);
            lblDetailsHint.TabIndex = 1;
            lblDetailsHint.Text = "These details are shown to event planners.";
            // 
            // row1
            // 
            row1.AutoSize = true;
            row1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            row1.Controls.Add(stackName);
            row1.Controls.Add(stackService);
            row1.Location = new Point(28, 113);
            row1.Margin = new Padding(0);
            row1.Name = "row1";
            row1.Size = new Size(704, 86);
            row1.TabIndex = 2;
            row1.WrapContents = false;
            // 
            // stackName
            // 
            stackName.AutoSize = true;
            stackName.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            stackName.Controls.Add(lblName);
            stackName.Controls.Add(txtName);
            stackName.FlowDirection = FlowDirection.TopDown;
            stackName.Location = new Point(0, 0);
            stackName.Margin = new Padding(0, 0, 12, 16);
            stackName.Name = "stackName";
            stackName.Size = new Size(346, 70);
            stackName.TabIndex = 0;
            stackName.WrapContents = false;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblName.ForeColor = Color.DimGray;
            lblName.Location = new Point(0, 0);
            lblName.Margin = new Padding(0, 0, 0, 6);
            lblName.Name = "lblName";
            lblName.Size = new Size(140, 25);
            lblName.TabIndex = 0;
            lblName.Text = "Business Name";
            // 
            // txtName
            // 
            txtName.BackColor = Color.WhiteSmoke;
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Font = new Font("Segoe UI", 12F);
            txtName.Location = new Point(0, 31);
            txtName.Margin = new Padding(0);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "e.g. Kigali Sounds Ltd";
            txtName.ReadOnly = true;
            txtName.Size = new Size(346, 39);
            txtName.TabIndex = 1;
            // 
            // stackService
            // 
            stackService.AutoSize = true;
            stackService.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            stackService.Controls.Add(lblService);
            stackService.Controls.Add(txtService);
            stackService.FlowDirection = FlowDirection.TopDown;
            stackService.Location = new Point(358, 0);
            stackService.Margin = new Padding(0, 0, 0, 16);
            stackService.Name = "stackService";
            stackService.Size = new Size(346, 70);
            stackService.TabIndex = 1;
            stackService.WrapContents = false;
            // 
            // lblService
            // 
            lblService.AutoSize = true;
            lblService.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblService.ForeColor = Color.DimGray;
            lblService.Location = new Point(0, 0);
            lblService.Margin = new Padding(0, 0, 0, 6);
            lblService.Name = "lblService";
            lblService.Size = new Size(120, 25);
            lblService.TabIndex = 0;
            lblService.Text = "Service Type";
            // 
            // txtService
            // 
            txtService.BackColor = Color.WhiteSmoke;
            txtService.BorderStyle = BorderStyle.FixedSingle;
            txtService.Font = new Font("Segoe UI", 12F);
            txtService.Location = new Point(0, 31);
            txtService.Margin = new Padding(0);
            txtService.Name = "txtService";
            txtService.PlaceholderText = "e.g. Catering, DJ, Photography";
            txtService.ReadOnly = true;
            txtService.Size = new Size(346, 39);
            txtService.TabIndex = 1;
            // 
            // row2
            // 
            row2.AutoSize = true;
            row2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            row2.Controls.Add(stackPriceMin);
            row2.Controls.Add(stackPriceMax);
            row2.Location = new Point(28, 199);
            row2.Margin = new Padding(0);
            row2.Name = "row2";
            row2.Size = new Size(704, 86);
            row2.TabIndex = 3;
            row2.WrapContents = false;
            // 
            // stackPriceMin
            // 
            stackPriceMin.AutoSize = true;
            stackPriceMin.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            stackPriceMin.Controls.Add(lblPriceMin);
            stackPriceMin.Controls.Add(txtPriceMin);
            stackPriceMin.FlowDirection = FlowDirection.TopDown;
            stackPriceMin.Location = new Point(0, 0);
            stackPriceMin.Margin = new Padding(0, 0, 12, 16);
            stackPriceMin.Name = "stackPriceMin";
            stackPriceMin.Size = new Size(346, 70);
            stackPriceMin.TabIndex = 0;
            stackPriceMin.WrapContents = false;
            // 
            // lblPriceMin
            // 
            lblPriceMin.AutoSize = true;
            lblPriceMin.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPriceMin.ForeColor = Color.DimGray;
            lblPriceMin.Location = new Point(0, 0);
            lblPriceMin.Margin = new Padding(0, 0, 0, 6);
            lblPriceMin.Name = "lblPriceMin";
            lblPriceMin.Size = new Size(198, 25);
            lblPriceMin.TabIndex = 0;
            lblPriceMin.Text = "Minimum Price (RWF)";
            // 
            // txtPriceMin
            // 
            txtPriceMin.BackColor = Color.WhiteSmoke;
            txtPriceMin.BorderStyle = BorderStyle.FixedSingle;
            txtPriceMin.Font = new Font("Segoe UI", 12F);
            txtPriceMin.Location = new Point(0, 31);
            txtPriceMin.Margin = new Padding(0);
            txtPriceMin.Name = "txtPriceMin";
            txtPriceMin.PlaceholderText = "e.g. 50000";
            txtPriceMin.ReadOnly = true;
            txtPriceMin.Size = new Size(346, 39);
            txtPriceMin.TabIndex = 1;
            // 
            // stackPriceMax
            // 
            stackPriceMax.AutoSize = true;
            stackPriceMax.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            stackPriceMax.Controls.Add(lblPriceMax);
            stackPriceMax.Controls.Add(txtPriceMax);
            stackPriceMax.FlowDirection = FlowDirection.TopDown;
            stackPriceMax.Location = new Point(358, 0);
            stackPriceMax.Margin = new Padding(0, 0, 0, 16);
            stackPriceMax.Name = "stackPriceMax";
            stackPriceMax.Size = new Size(346, 70);
            stackPriceMax.TabIndex = 1;
            stackPriceMax.WrapContents = false;
            // 
            // lblPriceMax
            // 
            lblPriceMax.AutoSize = true;
            lblPriceMax.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPriceMax.ForeColor = Color.DimGray;
            lblPriceMax.Location = new Point(0, 0);
            lblPriceMax.Margin = new Padding(0, 0, 0, 6);
            lblPriceMax.Name = "lblPriceMax";
            lblPriceMax.Size = new Size(202, 25);
            lblPriceMax.TabIndex = 0;
            lblPriceMax.Text = "Maximum Price (RWF)";
            // 
            // txtPriceMax
            // 
            txtPriceMax.BackColor = Color.WhiteSmoke;
            txtPriceMax.BorderStyle = BorderStyle.FixedSingle;
            txtPriceMax.Font = new Font("Segoe UI", 12F);
            txtPriceMax.Location = new Point(0, 31);
            txtPriceMax.Margin = new Padding(0);
            txtPriceMax.Name = "txtPriceMax";
            txtPriceMax.PlaceholderText = "e.g. 150000";
            txtPriceMax.ReadOnly = true;
            txtPriceMax.Size = new Size(346, 39);
            txtPriceMax.TabIndex = 1;
            // 
            // row3
            // 
            row3.AutoSize = true;
            row3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            row3.Controls.Add(stackLocation);
            row3.Location = new Point(28, 285);
            row3.Margin = new Padding(0);
            row3.Name = "row3";
            row3.Size = new Size(704, 86);
            row3.TabIndex = 4;
            row3.WrapContents = false;
            // 
            // stackLocation
            // 
            stackLocation.AutoSize = true;
            stackLocation.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            stackLocation.Controls.Add(lblLocation);
            stackLocation.Controls.Add(txtLocation);
            stackLocation.FlowDirection = FlowDirection.TopDown;
            stackLocation.Location = new Point(0, 0);
            stackLocation.Margin = new Padding(0, 0, 0, 16);
            stackLocation.Name = "stackLocation";
            stackLocation.Size = new Size(704, 70);
            stackLocation.TabIndex = 0;
            stackLocation.WrapContents = false;
            // 
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblLocation.ForeColor = Color.DimGray;
            lblLocation.Location = new Point(0, 0);
            lblLocation.Margin = new Padding(0, 0, 0, 6);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(85, 25);
            lblLocation.TabIndex = 0;
            lblLocation.Text = "Location";
            // 
            // txtLocation
            // 
            txtLocation.BackColor = Color.WhiteSmoke;
            txtLocation.BorderStyle = BorderStyle.FixedSingle;
            txtLocation.Font = new Font("Segoe UI", 12F);
            txtLocation.Location = new Point(0, 31);
            txtLocation.Margin = new Padding(0);
            txtLocation.Name = "txtLocation";
            txtLocation.PlaceholderText = "e.g. Kigali";
            txtLocation.ReadOnly = true;
            txtLocation.Size = new Size(704, 39);
            txtLocation.TabIndex = 1;
            // 
            // btnRow
            // 
            btnRow.AutoSize = true;
            btnRow.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnRow.Controls.Add(btnEditSave);
            btnRow.Controls.Add(btnCancel);
            btnRow.FlowDirection = FlowDirection.RightToLeft;
            btnRow.Location = new Point(28, 375);
            btnRow.Margin = new Padding(0, 4, 0, 0);
            btnRow.MinimumSize = new Size(704, 0);
            btnRow.Name = "btnRow";
            btnRow.Size = new Size(704, 46);
            btnRow.TabIndex = 5;
            btnRow.WrapContents = false;
            // 
            // btnEditSave
            // 
            btnEditSave.BackColor = Color.FromArgb(61, 76, 155);
            btnEditSave.Cursor = Cursors.Hand;
            btnEditSave.FlatAppearance.BorderSize = 0;
            btnEditSave.FlatStyle = FlatStyle.Flat;
            btnEditSave.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnEditSave.ForeColor = Color.White;
            btnEditSave.Location = new Point(514, 0);
            btnEditSave.Margin = new Padding(12, 0, 0, 0);
            btnEditSave.Name = "btnEditSave";
            btnEditSave.Size = new Size(190, 46);
            btnEditSave.TabIndex = 0;
            btnEditSave.Text = "Edit Profile";
            btnEditSave.UseVisualStyleBackColor = false;
            btnEditSave.Click += btnEditSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.White;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(222, 226, 234);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCancel.ForeColor = Color.DimGray;
            btnCancel.Location = new Point(382, 0);
            btnCancel.Margin = new Padding(0);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(120, 46);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Visible = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // bookingsView
            // 
            bookingsView.BackColor = Color.Transparent;
            bookingsView.Controls.Add(bkRoot);
            bookingsView.Dock = DockStyle.Fill;
            bookingsView.Location = new Point(30, 30);
            bookingsView.Name = "bookingsView";
            bookingsView.Size = new Size(868, 568);
            bookingsView.TabIndex = 1;
            bookingsView.Visible = false;
            // 
            // bkRoot
            // 
            bkRoot.BackColor = Color.Transparent;
            bkRoot.ColumnCount = 2;
            bkRoot.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            bkRoot.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 410F));
            bkRoot.Controls.Add(bkListCard, 0, 0);
            bkRoot.Controls.Add(bkDetailCard, 1, 0);
            bkRoot.Dock = DockStyle.Fill;
            bkRoot.Location = new Point(0, 0);
            bkRoot.Name = "bkRoot";
            bkRoot.RowCount = 1;
            bkRoot.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            bkRoot.Size = new Size(868, 568);
            bkRoot.TabIndex = 0;
            // 
            // bkListCard
            // 
            bkListCard.BackColor = Color.White;
            bkListCard.Controls.Add(gridBookings);
            bkListCard.Controls.Add(lblBookingsTitle);
            bkListCard.Dock = DockStyle.Fill;
            bkListCard.Location = new Point(0, 0);
            bkListCard.Margin = new Padding(0, 0, 16, 0);
            bkListCard.Name = "bkListCard";
            bkListCard.Padding = new Padding(24);
            bkListCard.Size = new Size(442, 568);
            bkListCard.TabIndex = 0;
            bkListCard.Paint += Card_Paint;
            // 
            // gridBookings
            // 
            gridBookings.AllowUserToAddRows = false;
            gridBookings.AllowUserToDeleteRows = false;
            gridBookings.AllowUserToResizeRows = false;
            gridBookings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridBookings.BackgroundColor = Color.White;
            gridBookings.BorderStyle = BorderStyle.None;
            gridBookings.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gridBookings.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            gridBookings.ColumnHeadersHeight = 42;
            gridBookings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            gridBookings.Dock = DockStyle.Fill;
            gridBookings.EnableHeadersVisualStyles = false;
            gridBookings.GridColor = Color.FromArgb(222, 226, 234);
            gridBookings.Location = new Point(24, 74);
            gridBookings.MultiSelect = false;
            gridBookings.Name = "gridBookings";
            gridBookings.ReadOnly = true;
            gridBookings.RowHeadersVisible = false;
            gridBookings.RowHeadersWidth = 62;
            gridBookings.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridBookings.Size = new Size(394, 470);
            gridBookings.TabIndex = 0;
            gridBookings.CellFormatting += Grid_CellFormatting;
            gridBookings.DataBindingComplete += Grid_DataBindingComplete;
            gridBookings.SelectionChanged += gridBookings_SelectionChanged;
            // 
            // lblBookingsTitle
            // 
            lblBookingsTitle.Dock = DockStyle.Top;
            lblBookingsTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblBookingsTitle.ForeColor = Color.FromArgb(40, 44, 70);
            lblBookingsTitle.Location = new Point(24, 24);
            lblBookingsTitle.Name = "lblBookingsTitle";
            lblBookingsTitle.Size = new Size(394, 50);
            lblBookingsTitle.TabIndex = 1;
            lblBookingsTitle.Text = "Incoming Booking Requests";
            // 
            // bkDetailCard
            // 
            bkDetailCard.BackColor = Color.White;
            bkDetailCard.Controls.Add(bkDetail);
            bkDetailCard.Dock = DockStyle.Fill;
            bkDetailCard.Location = new Point(458, 0);
            bkDetailCard.Margin = new Padding(0);
            bkDetailCard.Name = "bkDetailCard";
            bkDetailCard.Padding = new Padding(24);
            bkDetailCard.Size = new Size(410, 568);
            bkDetailCard.TabIndex = 1;
            bkDetailCard.Paint += Card_Paint;
            // 
            // bkDetail
            // 
            bkDetail.BackColor = Color.White;
            bkDetail.ColumnCount = 1;
            bkDetail.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            bkDetail.Controls.Add(lblBkEvent, 0, 0);
            bkDetail.Controls.Add(lblBkInfo, 0, 1);
            bkDetail.Controls.Add(lblBkStatus, 0, 2);
            bkDetail.Controls.Add(lblBkMsgCaption, 0, 3);
            bkDetail.Controls.Add(txtBkMessage, 0, 4);
            bkDetail.Controls.Add(lblBkRespCaption, 0, 5);
            bkDetail.Controls.Add(txtBkResponse, 0, 6);
            bkDetail.Controls.Add(actions, 0, 7);
            bkDetail.Dock = DockStyle.Fill;
            bkDetail.Location = new Point(24, 24);
            bkDetail.Name = "bkDetail";
            bkDetail.RowCount = 8;
            bkDetail.RowStyles.Add(new RowStyle());
            bkDetail.RowStyles.Add(new RowStyle());
            bkDetail.RowStyles.Add(new RowStyle());
            bkDetail.RowStyles.Add(new RowStyle());
            bkDetail.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            bkDetail.RowStyles.Add(new RowStyle());
            bkDetail.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            bkDetail.RowStyles.Add(new RowStyle());
            bkDetail.Size = new Size(362, 520);
            bkDetail.TabIndex = 0;
            // 
            // lblBkEvent
            // 
            lblBkEvent.Anchor = AnchorStyles.Left;
            lblBkEvent.AutoSize = true;
            lblBkEvent.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblBkEvent.ForeColor = Color.FromArgb(40, 44, 70);
            lblBkEvent.Location = new Point(0, 0);
            lblBkEvent.Margin = new Padding(0, 0, 0, 4);
            lblBkEvent.MaximumSize = new Size(350, 0);
            lblBkEvent.Name = "lblBkEvent";
            lblBkEvent.Size = new Size(297, 41);
            lblBkEvent.TabIndex = 0;
            lblBkEvent.Text = "No request selected";
            // 
            // lblBkInfo
            // 
            lblBkInfo.Anchor = AnchorStyles.Left;
            lblBkInfo.AutoSize = true;
            lblBkInfo.Font = new Font("Segoe UI", 9.5F);
            lblBkInfo.ForeColor = Color.Gray;
            lblBkInfo.Location = new Point(0, 45);
            lblBkInfo.Margin = new Padding(0, 0, 0, 8);
            lblBkInfo.MaximumSize = new Size(350, 0);
            lblBkInfo.Name = "lblBkInfo";
            lblBkInfo.Size = new Size(337, 50);
            lblBkInfo.TabIndex = 1;
            lblBkInfo.Text = "Pick a request from the list to read the message and reply.";
            // 
            // lblBkStatus
            // 
            lblBkStatus.Anchor = AnchorStyles.Left;
            lblBkStatus.AutoSize = true;
            lblBkStatus.BackColor = Color.FromArgb(255, 193, 7);
            lblBkStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblBkStatus.ForeColor = Color.Black;
            lblBkStatus.Location = new Point(0, 103);
            lblBkStatus.Margin = new Padding(0, 0, 0, 16);
            lblBkStatus.Name = "lblBkStatus";
            lblBkStatus.Padding = new Padding(12, 4, 12, 4);
            lblBkStatus.Size = new Size(126, 33);
            lblBkStatus.TabIndex = 2;
            lblBkStatus.Text = "●  Pending";
            lblBkStatus.Visible = false;
            // 
            // lblBkMsgCaption
            // 
            lblBkMsgCaption.Anchor = AnchorStyles.Left;
            lblBkMsgCaption.AutoSize = true;
            lblBkMsgCaption.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblBkMsgCaption.ForeColor = Color.DimGray;
            lblBkMsgCaption.Location = new Point(0, 152);
            lblBkMsgCaption.Margin = new Padding(0, 0, 0, 6);
            lblBkMsgCaption.MaximumSize = new Size(350, 0);
            lblBkMsgCaption.Name = "lblBkMsgCaption";
            lblBkMsgCaption.Size = new Size(167, 25);
            lblBkMsgCaption.TabIndex = 3;
            lblBkMsgCaption.Text = "Planner's message";
            // 
            // txtBkMessage
            // 
            txtBkMessage.BackColor = Color.WhiteSmoke;
            txtBkMessage.BorderStyle = BorderStyle.FixedSingle;
            txtBkMessage.Dock = DockStyle.Fill;
            txtBkMessage.Font = new Font("Segoe UI", 10.5F);
            txtBkMessage.Location = new Point(0, 183);
            txtBkMessage.Margin = new Padding(0, 0, 0, 14);
            txtBkMessage.Multiline = true;
            txtBkMessage.Name = "txtBkMessage";
            txtBkMessage.ReadOnly = true;
            txtBkMessage.ScrollBars = ScrollBars.Vertical;
            txtBkMessage.Size = new Size(362, 103);
            txtBkMessage.TabIndex = 4;
            // 
            // lblBkRespCaption
            // 
            lblBkRespCaption.Anchor = AnchorStyles.Left;
            lblBkRespCaption.AutoSize = true;
            lblBkRespCaption.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblBkRespCaption.ForeColor = Color.DimGray;
            lblBkRespCaption.Location = new Point(0, 300);
            lblBkRespCaption.Margin = new Padding(0, 0, 0, 6);
            lblBkRespCaption.MaximumSize = new Size(350, 0);
            lblBkRespCaption.Name = "lblBkRespCaption";
            lblBkRespCaption.Size = new Size(331, 50);
            lblBkRespCaption.TabIndex = 5;
            lblBkRespCaption.Text = "Your response (optional: explain why you accept or reject)";
            // 
            // txtBkResponse
            // 
            txtBkResponse.BackColor = Color.White;
            txtBkResponse.BorderStyle = BorderStyle.FixedSingle;
            txtBkResponse.Dock = DockStyle.Fill;
            txtBkResponse.Font = new Font("Segoe UI", 10.5F);
            txtBkResponse.Location = new Point(0, 356);
            txtBkResponse.Margin = new Padding(0, 0, 0, 14);
            txtBkResponse.Multiline = true;
            txtBkResponse.Name = "txtBkResponse";
            txtBkResponse.ReadOnly = true;
            txtBkResponse.ScrollBars = ScrollBars.Vertical;
            txtBkResponse.Size = new Size(362, 103);
            txtBkResponse.TabIndex = 6;
            // 
            // actions
            // 
            actions.AutoSize = true;
            actions.ColumnCount = 2;
            actions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            actions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            actions.Controls.Add(btnAccept, 0, 0);
            actions.Controls.Add(btnReject, 1, 0);
            actions.Dock = DockStyle.Fill;
            actions.Location = new Point(0, 473);
            actions.Margin = new Padding(0);
            actions.Name = "actions";
            actions.RowCount = 1;
            actions.RowStyles.Add(new RowStyle());
            actions.Size = new Size(362, 47);
            actions.TabIndex = 7;
            // 
            // btnAccept
            // 
            btnAccept.BackColor = Color.FromArgb(40, 160, 90);
            btnAccept.Cursor = Cursors.Hand;
            btnAccept.Dock = DockStyle.Fill;
            btnAccept.Enabled = false;
            btnAccept.FlatAppearance.BorderSize = 0;
            btnAccept.FlatStyle = FlatStyle.Flat;
            btnAccept.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnAccept.ForeColor = Color.White;
            btnAccept.Location = new Point(0, 0);
            btnAccept.Margin = new Padding(0, 0, 6, 0);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(175, 47);
            btnAccept.TabIndex = 0;
            btnAccept.Text = "Accept";
            btnAccept.UseVisualStyleBackColor = false;
            btnAccept.Click += btnAccept_Click;
            // 
            // btnReject
            // 
            btnReject.BackColor = Color.FromArgb(214, 69, 65);
            btnReject.Cursor = Cursors.Hand;
            btnReject.Dock = DockStyle.Fill;
            btnReject.Enabled = false;
            btnReject.FlatAppearance.BorderSize = 0;
            btnReject.FlatStyle = FlatStyle.Flat;
            btnReject.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnReject.ForeColor = Color.White;
            btnReject.Location = new Point(187, 0);
            btnReject.Margin = new Padding(6, 0, 0, 0);
            btnReject.Name = "btnReject";
            btnReject.Size = new Size(175, 47);
            btnReject.TabIndex = 1;
            btnReject.Text = "Reject";
            btnReject.UseVisualStyleBackColor = false;
            btnReject.Click += btnReject_Click;
            // 
            // header
            // 
            header.BackColor = Color.White;
            header.Controls.Add(lblUser);
            header.Controls.Add(lblHeaderTitle);
            header.Controls.Add(headerLine);
            header.Dock = DockStyle.Top;
            header.Location = new Point(250, 0);
            header.Name = "header";
            header.Size = new Size(928, 76);
            header.TabIndex = 1;
            // 
            // lblUser
            // 
            lblUser.Dock = DockStyle.Right;
            lblUser.Font = new Font("Segoe UI", 9F);
            lblUser.ForeColor = Color.Gray;
            lblUser.Location = new Point(628, 0);
            lblUser.Name = "lblUser";
            lblUser.Padding = new Padding(0, 0, 25, 0);
            lblUser.Size = new Size(300, 75);
            lblUser.TabIndex = 0;
            lblUser.Text = "vendor@example.com";
            lblUser.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblHeaderTitle
            // 
            lblHeaderTitle.Dock = DockStyle.Left;
            lblHeaderTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblHeaderTitle.ForeColor = Color.FromArgb(40, 44, 70);
            lblHeaderTitle.Location = new Point(0, 0);
            lblHeaderTitle.Name = "lblHeaderTitle";
            lblHeaderTitle.Padding = new Padding(30, 0, 0, 0);
            lblHeaderTitle.Size = new Size(420, 75);
            lblHeaderTitle.TabIndex = 1;
            lblHeaderTitle.Text = "My Profile";
            lblHeaderTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // headerLine
            // 
            headerLine.BackColor = Color.FromArgb(222, 226, 234);
            headerLine.Dock = DockStyle.Bottom;
            headerLine.Location = new Point(0, 75);
            headerLine.Name = "headerLine";
            headerLine.Size = new Size(928, 1);
            headerLine.TabIndex = 2;
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(61, 76, 155);
            sidebar.Controls.Add(btnProfile);
            sidebar.Controls.Add(btnBookings);
            sidebar.Controls.Add(btnLogout);
            sidebar.Controls.Add(logo);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 0);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(250, 704);
            sidebar.TabIndex = 2;
            // 
            // btnProfile
            // 
            btnProfile.BackColor = Color.FromArgb(61, 76, 155);
            btnProfile.Cursor = Cursors.Hand;
            btnProfile.FlatAppearance.BorderSize = 0;
            btnProfile.FlatAppearance.MouseOverBackColor = Color.FromArgb(80, 100, 180);
            btnProfile.FlatStyle = FlatStyle.Flat;
            btnProfile.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnProfile.ForeColor = Color.White;
            btnProfile.Location = new Point(0, 100);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(250, 45);
            btnProfile.TabIndex = 0;
            btnProfile.Text = "   My Profile";
            btnProfile.TextAlign = ContentAlignment.MiddleLeft;
            btnProfile.UseVisualStyleBackColor = false;
            btnProfile.Click += btnProfile_Click;
            btnProfile.Paint += SidebarButton_Paint;
            // 
            // btnBookings
            // 
            btnBookings.BackColor = Color.FromArgb(61, 76, 155);
            btnBookings.Cursor = Cursors.Hand;
            btnBookings.FlatAppearance.BorderSize = 0;
            btnBookings.FlatAppearance.MouseOverBackColor = Color.FromArgb(80, 100, 180);
            btnBookings.FlatStyle = FlatStyle.Flat;
            btnBookings.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnBookings.ForeColor = Color.White;
            btnBookings.Location = new Point(0, 150);
            btnBookings.Name = "btnBookings";
            btnBookings.Size = new Size(250, 45);
            btnBookings.TabIndex = 1;
            btnBookings.Text = "   Booking Requests";
            btnBookings.TextAlign = ContentAlignment.MiddleLeft;
            btnBookings.UseVisualStyleBackColor = false;
            btnBookings.Click += btnBookings_Click;
            btnBookings.Paint += SidebarButton_Paint;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(61, 76, 155);
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatAppearance.MouseOverBackColor = Color.FromArgb(80, 100, 180);
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(0, 649);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(250, 55);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "   Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            btnLogout.Paint += SidebarButton_Paint;
            // 
            // logo
            // 
            logo.Dock = DockStyle.Top;
            logo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            logo.ForeColor = Color.White;
            logo.Location = new Point(0, 0);
            logo.Name = "logo";
            logo.Size = new Size(250, 80);
            logo.TabIndex = 3;
            logo.Text = "EventKonnect";
            logo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // VendorForm
            // 
            BackColor = Color.FromArgb(244, 246, 249);
            ClientSize = new Size(1178, 704);
            Controls.Add(mainContainer);
            Controls.Add(header);
            Controls.Add(sidebar);
            MinimumSize = new Size(1100, 700);
            Name = "VendorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Vendor Dashboard";
            Load += VendorForm_Load;
            mainContainer.ResumeLayout(false);
            profileView.ResumeLayout(false);
            profileView.PerformLayout();
            page.ResumeLayout(false);
            page.PerformLayout();
            hero.ResumeLayout(false);
            hero.PerformLayout();
            heroText.ResumeLayout(false);
            heroText.PerformLayout();
            statsRow.ResumeLayout(false);
            statsRow.PerformLayout();
            cardStatTotal.ResumeLayout(false);
            cardStatTotal.PerformLayout();
            cardStatPending.ResumeLayout(false);
            cardStatPending.PerformLayout();
            cardStatAccepted.ResumeLayout(false);
            cardStatAccepted.PerformLayout();
            details.ResumeLayout(false);
            details.PerformLayout();
            row1.ResumeLayout(false);
            row1.PerformLayout();
            stackName.ResumeLayout(false);
            stackName.PerformLayout();
            stackService.ResumeLayout(false);
            stackService.PerformLayout();
            row2.ResumeLayout(false);
            row2.PerformLayout();
            stackPriceMin.ResumeLayout(false);
            stackPriceMin.PerformLayout();
            stackPriceMax.ResumeLayout(false);
            stackPriceMax.PerformLayout();
            row3.ResumeLayout(false);
            row3.PerformLayout();
            stackLocation.ResumeLayout(false);
            stackLocation.PerformLayout();
            btnRow.ResumeLayout(false);
            bookingsView.ResumeLayout(false);
            bkRoot.ResumeLayout(false);
            bkListCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridBookings).EndInit();
            bkDetailCard.ResumeLayout(false);
            bkDetail.ResumeLayout(false);
            bkDetail.PerformLayout();
            actions.ResumeLayout(false);
            header.ResumeLayout(false);
            sidebar.ResumeLayout(false);
            ResumeLayout(false);
        }

#endregion

        private System.Windows.Forms.Panel mainContainer;
        private System.Windows.Forms.Panel profileView;
        private System.Windows.Forms.FlowLayoutPanel page;
        private System.Windows.Forms.FlowLayoutPanel hero;
        private System.Windows.Forms.Panel avatar;
        private System.Windows.Forms.FlowLayoutPanel heroText;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Label lblPill;
        private System.Windows.Forms.FlowLayoutPanel statsRow;
        private System.Windows.Forms.FlowLayoutPanel cardStatTotal;
        private System.Windows.Forms.Label lblStatTotal;
        private System.Windows.Forms.Label lblStatTotalCaption;
        private System.Windows.Forms.FlowLayoutPanel cardStatPending;
        private System.Windows.Forms.Label lblStatPending;
        private System.Windows.Forms.Label lblStatPendingCaption;
        private System.Windows.Forms.FlowLayoutPanel cardStatAccepted;
        private System.Windows.Forms.Label lblStatAccepted;
        private System.Windows.Forms.Label lblStatAcceptedCaption;
        private System.Windows.Forms.FlowLayoutPanel details;
        private System.Windows.Forms.Label lblDetailsTitle;
        private System.Windows.Forms.Label lblDetailsHint;
        private System.Windows.Forms.FlowLayoutPanel row1;
        private System.Windows.Forms.FlowLayoutPanel stackName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.FlowLayoutPanel stackService;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.TextBox txtService;
        private System.Windows.Forms.FlowLayoutPanel row2;
        private System.Windows.Forms.FlowLayoutPanel stackPriceMin;
        private System.Windows.Forms.Label lblPriceMin;
        private System.Windows.Forms.TextBox txtPriceMin;
        private System.Windows.Forms.FlowLayoutPanel stackPriceMax;
        private System.Windows.Forms.Label lblPriceMax;
        private System.Windows.Forms.TextBox txtPriceMax;
        private System.Windows.Forms.FlowLayoutPanel row3;
        private System.Windows.Forms.FlowLayoutPanel stackLocation;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.FlowLayoutPanel btnRow;
        private System.Windows.Forms.Button btnEditSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel bookingsView;
        private System.Windows.Forms.TableLayoutPanel bkRoot;
        private System.Windows.Forms.Panel bkListCard;
        private System.Windows.Forms.DataGridView gridBookings;
        private System.Windows.Forms.Label lblBookingsTitle;
        private System.Windows.Forms.Panel bkDetailCard;
        private System.Windows.Forms.TableLayoutPanel bkDetail;
        private System.Windows.Forms.Label lblBkEvent;
        private System.Windows.Forms.Label lblBkInfo;
        private System.Windows.Forms.Label lblBkStatus;
        private System.Windows.Forms.Label lblBkMsgCaption;
        private System.Windows.Forms.TextBox txtBkMessage;
        private System.Windows.Forms.Label lblBkRespCaption;
        private System.Windows.Forms.TextBox txtBkResponse;
        private System.Windows.Forms.TableLayoutPanel actions;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnReject;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Panel headerLine;
        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnBookings;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label logo;
    }
}
