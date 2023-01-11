
namespace Primitives
{
    partial class Primitives
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
            devDept.Eyeshot.CancelToolBarButton cancelToolBarButton3 = new devDept.Eyeshot.CancelToolBarButton("Cancel", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.ProgressBar progressBar3 = new devDept.Eyeshot.ProgressBar(devDept.Eyeshot.ProgressBar.styleType.Circular, 0, "Idle", System.Drawing.Color.Black, System.Drawing.Color.Transparent, System.Drawing.Color.Green, 1D, true, cancelToolBarButton3, false, 0.1D, 0.333D, true);
            devDept.Graphics.BackgroundSettings backgroundSettings3 = new devDept.Graphics.BackgroundSettings(devDept.Graphics.backgroundStyleType.LinearGradient, System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245))))), System.Drawing.Color.DodgerBlue, System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(210))))), 0.75D, null, devDept.Graphics.colorThemeType.Auto, 0.33D);
            devDept.Eyeshot.Camera camera3 = new devDept.Eyeshot.Camera(new devDept.Geometry.Point3D(0D, 0D, 45D), 380D, new devDept.Geometry.Quaternion(0.018434349666532526D, 0.039532590434972079D, 0.42221602280006187D, 0.90544518284475428D), devDept.Graphics.projectionType.Perspective, 40D, 4.130000114440918D, false, 0.001D);
            devDept.Eyeshot.HomeToolBarButton homeToolBarButton3 = new devDept.Eyeshot.HomeToolBarButton("Home", devDept.Eyeshot.ToolBarButton.styleType.PushButton, true, true);
            devDept.Eyeshot.MagnifyingGlassToolBarButton magnifyingGlassToolBarButton3 = new devDept.Eyeshot.MagnifyingGlassToolBarButton("Magnifying Glass", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.ZoomWindowToolBarButton zoomWindowToolBarButton3 = new devDept.Eyeshot.ZoomWindowToolBarButton("Zoom Window", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.ZoomToolBarButton zoomToolBarButton3 = new devDept.Eyeshot.ZoomToolBarButton("Zoom", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.PanToolBarButton panToolBarButton3 = new devDept.Eyeshot.PanToolBarButton("Pan", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.RotateToolBarButton rotateToolBarButton3 = new devDept.Eyeshot.RotateToolBarButton("Rotate", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.ZoomFitToolBarButton zoomFitToolBarButton3 = new devDept.Eyeshot.ZoomFitToolBarButton("Zoom Fit", devDept.Eyeshot.ToolBarButton.styleType.PushButton, true, true);
            devDept.Eyeshot.ToolBar toolBar3 = new devDept.Eyeshot.ToolBar(devDept.Eyeshot.ToolBar.positionType.HorizontalTopCenter, true, new devDept.Eyeshot.ToolBarButton[] {
            ((devDept.Eyeshot.ToolBarButton)(homeToolBarButton3)),
            ((devDept.Eyeshot.ToolBarButton)(magnifyingGlassToolBarButton3)),
            ((devDept.Eyeshot.ToolBarButton)(zoomWindowToolBarButton3)),
            ((devDept.Eyeshot.ToolBarButton)(zoomToolBarButton3)),
            ((devDept.Eyeshot.ToolBarButton)(panToolBarButton3)),
            ((devDept.Eyeshot.ToolBarButton)(rotateToolBarButton3)),
            ((devDept.Eyeshot.ToolBarButton)(zoomFitToolBarButton3))});
            devDept.Eyeshot.Histogram histogram3 = new devDept.Eyeshot.Histogram(30, 80, "Title", System.Drawing.Color.Blue, System.Drawing.Color.Gray, System.Drawing.Color.Black, System.Drawing.Color.Red, System.Drawing.Color.LightYellow, false, true, false, "{0:+0.###;-0.###;0}");
            devDept.Eyeshot.Grid grid3 = new devDept.Eyeshot.Grid(new devDept.Geometry.Point2D(-100D, -100D), new devDept.Geometry.Point2D(100D, 100D), 10D, new devDept.Geometry.Plane(new devDept.Geometry.Point3D(0D, 0D, 0D), new devDept.Geometry.Vector3D(0D, 0D, 1D)), System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))), System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))), System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0))))), false, true, false, false, 10, 100, 10, System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90))))), System.Drawing.Color.Transparent, false, System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255))))));
            devDept.Eyeshot.OriginSymbol originSymbol3 = new devDept.Eyeshot.OriginSymbol(10, devDept.Eyeshot.originSymbolStyleType.Ball, new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129))), System.Drawing.Color.Black, System.Drawing.Color.Black, System.Drawing.Color.Black, System.Drawing.Color.Black, System.Drawing.Color.Red, System.Drawing.Color.Green, System.Drawing.Color.Blue, "Origin", "X", "Y", "Z", true, null, false);
            devDept.Eyeshot.RotateSettings rotateSettings3 = new devDept.Eyeshot.RotateSettings(new devDept.Eyeshot.MouseButton(devDept.Eyeshot.mouseButtonsZPR.Middle, devDept.Eyeshot.modifierKeys.None), 10D, true, 1D, devDept.Eyeshot.rotationType.Trackball, devDept.Eyeshot.rotationCenterType.CursorLocation, new devDept.Geometry.Point3D(0D, 0D, 0D), false);
            devDept.Eyeshot.ZoomSettings zoomSettings3 = new devDept.Eyeshot.ZoomSettings(new devDept.Eyeshot.MouseButton(devDept.Eyeshot.mouseButtonsZPR.Middle, devDept.Eyeshot.modifierKeys.Shift), 25, true, devDept.Eyeshot.zoomStyleType.AtCursorLocation, false, 1D, System.Drawing.Color.Empty, devDept.Eyeshot.Camera.perspectiveFitType.Accurate, false, 10, true);
            devDept.Eyeshot.PanSettings panSettings3 = new devDept.Eyeshot.PanSettings(new devDept.Eyeshot.MouseButton(devDept.Eyeshot.mouseButtonsZPR.Middle, devDept.Eyeshot.modifierKeys.Ctrl), 25, true);
            devDept.Eyeshot.NavigationSettings navigationSettings3 = new devDept.Eyeshot.NavigationSettings(devDept.Eyeshot.Camera.navigationType.Examine, new devDept.Eyeshot.MouseButton(devDept.Eyeshot.mouseButtonsZPR.Left, devDept.Eyeshot.modifierKeys.None), new devDept.Geometry.Point3D(-1000D, -1000D, -1000D), new devDept.Geometry.Point3D(1000D, 1000D, 1000D), 8D, 50D, 50D);
            devDept.Eyeshot.CoordinateSystemIcon coordinateSystemIcon3 = new devDept.Eyeshot.CoordinateSystemIcon(new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129))), System.Drawing.Color.Black, System.Drawing.Color.Black, System.Drawing.Color.Black, System.Drawing.Color.Black, System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80))))), System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80))))), System.Drawing.Color.OrangeRed, "Origin", "X", "Y", "Z", true, devDept.Eyeshot.coordinateSystemPositionType.BottomLeft, 37, null, false);
            devDept.Eyeshot.ViewCubeIcon viewCubeIcon3 = new devDept.Eyeshot.ViewCubeIcon(devDept.Eyeshot.coordinateSystemPositionType.TopRight, true, System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(20)))), ((int)(((byte)(60))))), true, "FRONT", "BACK", "LEFT", "RIGHT", "TOP", "BOTTOM", System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), 'S', 'N', 'W', 'E', true, null, System.Drawing.Color.White, System.Drawing.Color.Black, 120, true, true, null, null, null, null, null, null, false, new devDept.Geometry.Quaternion(0D, 0D, 0D, 1D), true);
            devDept.Eyeshot.Viewport.SavedViewsManager savedViewsManager3 = new devDept.Eyeshot.Viewport.SavedViewsManager(8);
            devDept.Eyeshot.Viewport viewport3 = new devDept.Eyeshot.Viewport(new System.Drawing.Point(0, 0), new System.Drawing.Size(1236, 413), backgroundSettings3, camera3, new devDept.Eyeshot.ToolBar[] {
            toolBar3}, new devDept.Eyeshot.Legend[0], histogram3, devDept.Eyeshot.displayType.Rendered, true, false, false, false, new devDept.Eyeshot.Grid[] {
            grid3}, new devDept.Eyeshot.OriginSymbol[] {
            originSymbol3}, false, rotateSettings3, zoomSettings3, panSettings3, navigationSettings3, coordinateSystemIcon3, viewCubeIcon3, savedViewsManager3, devDept.Eyeshot.viewType.Trimetric);
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnTorus = new System.Windows.Forms.Button();
            this.tbMinorRadius = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tbMajorRadius = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cbClose = new System.Windows.Forms.CheckBox();
            this.cbReverseTwist = new System.Windows.Forms.CheckBox();
            this.btnSpring = new System.Windows.Forms.Button();
            this.tbTurns = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbPitch = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbWireRadius = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tbSpringRadius = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnSphere = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.tbSphereRadius = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnCylinder = new System.Windows.Forms.Button();
            this.tbCylinderHeight = new System.Windows.Forms.TextBox();
            this.tbCylinderRadius = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCone = new System.Windows.Forms.Button();
            this.tbConeHeight = new System.Windows.Forms.TextBox();
            this.tbBaseRadius = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbTopRadius = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBox = new System.Windows.Forms.Button();
            this.tbBoxHeight = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbBoxDepth = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbBoxWidth = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnArrow = new System.Windows.Forms.Button();
            this.tbConeLength = new System.Windows.Forms.TextBox();
            this.tbConeRadius = new System.Windows.Forms.TextBox();
            this.tbCylLength = new System.Windows.Forms.TextBox();
            this.tbCylRadius = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.design1 = new devDept.Eyeshot.Design();
            this.panel1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.design1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox7);
            this.panel1.Controls.Add(this.groupBox6);
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 413);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1236, 209);
            this.panel1.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnTorus);
            this.groupBox7.Controls.Add(this.tbMinorRadius);
            this.groupBox7.Controls.Add(this.label18);
            this.groupBox7.Controls.Add(this.tbMajorRadius);
            this.groupBox7.Controls.Add(this.label19);
            this.groupBox7.Location = new System.Drawing.Point(1073, 15);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(154, 182);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Torus";
            // 
            // btnTorus
            // 
            this.btnTorus.Location = new System.Drawing.Point(13, 138);
            this.btnTorus.Name = "btnTorus";
            this.btnTorus.Size = new System.Drawing.Size(126, 32);
            this.btnTorus.TabIndex = 3;
            this.btnTorus.Text = "Torus";
            this.btnTorus.UseVisualStyleBackColor = true;
            this.btnTorus.Click += new System.EventHandler(this.btnTorus_Click);
            // 
            // tbMinorRadius
            // 
            this.tbMinorRadius.Location = new System.Drawing.Point(94, 50);
            this.tbMinorRadius.Name = "tbMinorRadius";
            this.tbMinorRadius.Size = new System.Drawing.Size(54, 21);
            this.tbMinorRadius.TabIndex = 2;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(5, 26);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(76, 12);
            this.label18.TabIndex = 0;
            this.label18.Text = "majorRadius";
            // 
            // tbMajorRadius
            // 
            this.tbMajorRadius.Location = new System.Drawing.Point(94, 23);
            this.tbMajorRadius.Name = "tbMajorRadius";
            this.tbMajorRadius.Size = new System.Drawing.Size(54, 21);
            this.tbMajorRadius.TabIndex = 1;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 53);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(76, 12);
            this.label19.TabIndex = 0;
            this.label19.Text = "minorRadius";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.cbClose);
            this.groupBox6.Controls.Add(this.cbReverseTwist);
            this.groupBox6.Controls.Add(this.btnSpring);
            this.groupBox6.Controls.Add(this.tbTurns);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.tbPitch);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Controls.Add(this.tbWireRadius);
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Controls.Add(this.tbSpringRadius);
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Location = new System.Drawing.Point(814, 15);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(253, 182);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Spring";
            // 
            // cbClose
            // 
            this.cbClose.AutoSize = true;
            this.cbClose.Location = new System.Drawing.Point(150, 79);
            this.cbClose.Name = "cbClose";
            this.cbClose.Size = new System.Drawing.Size(55, 16);
            this.cbClose.TabIndex = 6;
            this.cbClose.Text = "close";
            this.cbClose.UseVisualStyleBackColor = true;
            // 
            // cbReverseTwist
            // 
            this.cbReverseTwist.AutoSize = true;
            this.cbReverseTwist.Location = new System.Drawing.Point(150, 52);
            this.cbReverseTwist.Name = "cbReverseTwist";
            this.cbReverseTwist.Size = new System.Drawing.Size(97, 16);
            this.cbReverseTwist.TabIndex = 5;
            this.cbReverseTwist.Text = "reverseTwist";
            this.cbReverseTwist.UseVisualStyleBackColor = true;
            // 
            // btnSpring
            // 
            this.btnSpring.Location = new System.Drawing.Point(17, 138);
            this.btnSpring.Name = "btnSpring";
            this.btnSpring.Size = new System.Drawing.Size(230, 32);
            this.btnSpring.TabIndex = 7;
            this.btnSpring.Text = "Spring";
            this.btnSpring.UseVisualStyleBackColor = true;
            this.btnSpring.Click += new System.EventHandler(this.btnSpring_Click);
            // 
            // tbTurns
            // 
            this.tbTurns.Location = new System.Drawing.Point(90, 101);
            this.tbTurns.Name = "tbTurns";
            this.tbTurns.Size = new System.Drawing.Size(54, 21);
            this.tbTurns.TabIndex = 4;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(34, 23);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 12);
            this.label14.TabIndex = 0;
            this.label14.Text = "radius";
            // 
            // tbPitch
            // 
            this.tbPitch.Location = new System.Drawing.Point(90, 74);
            this.tbPitch.Name = "tbPitch";
            this.tbPitch.Size = new System.Drawing.Size(54, 21);
            this.tbPitch.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 50);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 12);
            this.label15.TabIndex = 0;
            this.label15.Text = "wireRadius";
            // 
            // tbWireRadius
            // 
            this.tbWireRadius.Location = new System.Drawing.Point(90, 47);
            this.tbWireRadius.Name = "tbWireRadius";
            this.tbWireRadius.Size = new System.Drawing.Size(54, 21);
            this.tbWireRadius.TabIndex = 2;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(42, 77);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(32, 12);
            this.label16.TabIndex = 0;
            this.label16.Text = "pitch";
            // 
            // tbSpringRadius
            // 
            this.tbSpringRadius.Location = new System.Drawing.Point(90, 20);
            this.tbSpringRadius.Name = "tbSpringRadius";
            this.tbSpringRadius.Size = new System.Drawing.Size(54, 21);
            this.tbSpringRadius.TabIndex = 1;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(41, 104);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(33, 12);
            this.label17.TabIndex = 0;
            this.label17.Text = "turns";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnSphere);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.tbSphereRadius);
            this.groupBox5.Location = new System.Drawing.Point(654, 15);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(154, 182);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Sphere";
            // 
            // btnSphere
            // 
            this.btnSphere.Location = new System.Drawing.Point(17, 138);
            this.btnSphere.Name = "btnSphere";
            this.btnSphere.Size = new System.Drawing.Size(126, 32);
            this.btnSphere.TabIndex = 2;
            this.btnSphere.Text = "Sphere";
            this.btnSphere.UseVisualStyleBackColor = true;
            this.btnSphere.Click += new System.EventHandler(this.btnSphere_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 12);
            this.label13.TabIndex = 0;
            this.label13.Text = "radius";
            // 
            // tbSphereRadius
            // 
            this.tbSphereRadius.Location = new System.Drawing.Point(89, 20);
            this.tbSphereRadius.Name = "tbSphereRadius";
            this.tbSphereRadius.Size = new System.Drawing.Size(54, 21);
            this.tbSphereRadius.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnCylinder);
            this.groupBox4.Controls.Add(this.tbCylinderHeight);
            this.groupBox4.Controls.Add(this.tbCylinderRadius);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Location = new System.Drawing.Point(494, 15);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(154, 182);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Cylinder";
            // 
            // btnCylinder
            // 
            this.btnCylinder.Location = new System.Drawing.Point(15, 138);
            this.btnCylinder.Name = "btnCylinder";
            this.btnCylinder.Size = new System.Drawing.Size(126, 32);
            this.btnCylinder.TabIndex = 3;
            this.btnCylinder.Text = "Cylinder";
            this.btnCylinder.UseVisualStyleBackColor = true;
            this.btnCylinder.Click += new System.EventHandler(this.btnCylinder_Click);
            // 
            // tbCylinderHeight
            // 
            this.tbCylinderHeight.Location = new System.Drawing.Point(87, 47);
            this.tbCylinderHeight.Name = "tbCylinderHeight";
            this.tbCylinderHeight.Size = new System.Drawing.Size(54, 21);
            this.tbCylinderHeight.TabIndex = 2;
            // 
            // tbCylinderRadius
            // 
            this.tbCylinderRadius.Location = new System.Drawing.Point(87, 20);
            this.tbCylinderRadius.Name = "tbCylinderRadius";
            this.tbCylinderRadius.Size = new System.Drawing.Size(54, 21);
            this.tbCylinderRadius.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 12);
            this.label11.TabIndex = 0;
            this.label11.Text = "height";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 12);
            this.label12.TabIndex = 0;
            this.label12.Text = "radius";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCone);
            this.groupBox3.Controls.Add(this.tbConeHeight);
            this.groupBox3.Controls.Add(this.tbBaseRadius);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.tbTopRadius);
            this.groupBox3.Location = new System.Drawing.Point(334, 15);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(154, 182);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cone";
            // 
            // btnCone
            // 
            this.btnCone.Location = new System.Drawing.Point(13, 138);
            this.btnCone.Name = "btnCone";
            this.btnCone.Size = new System.Drawing.Size(126, 32);
            this.btnCone.TabIndex = 4;
            this.btnCone.Text = "Cone";
            this.btnCone.UseVisualStyleBackColor = true;
            this.btnCone.Click += new System.EventHandler(this.btnCone_Click);
            // 
            // tbConeHeight
            // 
            this.tbConeHeight.Location = new System.Drawing.Point(85, 74);
            this.tbConeHeight.Name = "tbConeHeight";
            this.tbConeHeight.Size = new System.Drawing.Size(54, 21);
            this.tbConeHeight.TabIndex = 3;
            // 
            // tbBaseRadius
            // 
            this.tbBaseRadius.Location = new System.Drawing.Point(85, 20);
            this.tbBaseRadius.Name = "tbBaseRadius";
            this.tbBaseRadius.Size = new System.Drawing.Size(54, 21);
            this.tbBaseRadius.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "baseRadius";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "height";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "topRadius";
            // 
            // tbTopRadius
            // 
            this.tbTopRadius.Location = new System.Drawing.Point(85, 47);
            this.tbTopRadius.Name = "tbTopRadius";
            this.tbTopRadius.Size = new System.Drawing.Size(54, 21);
            this.tbTopRadius.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBox);
            this.groupBox2.Controls.Add(this.tbBoxHeight);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tbBoxDepth);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tbBoxWidth);
            this.groupBox2.Location = new System.Drawing.Point(174, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(154, 182);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Box";
            // 
            // btnBox
            // 
            this.btnBox.Location = new System.Drawing.Point(13, 138);
            this.btnBox.Name = "btnBox";
            this.btnBox.Size = new System.Drawing.Size(126, 32);
            this.btnBox.TabIndex = 4;
            this.btnBox.Text = "Box";
            this.btnBox.UseVisualStyleBackColor = true;
            this.btnBox.Click += new System.EventHandler(this.btnBox_Click);
            // 
            // tbBoxHeight
            // 
            this.tbBoxHeight.Location = new System.Drawing.Point(85, 74);
            this.tbBoxHeight.Name = "tbBoxHeight";
            this.tbBoxHeight.Size = new System.Drawing.Size(54, 21);
            this.tbBoxHeight.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "width";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "depth";
            // 
            // tbBoxDepth
            // 
            this.tbBoxDepth.Location = new System.Drawing.Point(85, 47);
            this.tbBoxDepth.Name = "tbBoxDepth";
            this.tbBoxDepth.Size = new System.Drawing.Size(54, 21);
            this.tbBoxDepth.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "height";
            // 
            // tbBoxWidth
            // 
            this.tbBoxWidth.Location = new System.Drawing.Point(85, 20);
            this.tbBoxWidth.Name = "tbBoxWidth";
            this.tbBoxWidth.Size = new System.Drawing.Size(54, 21);
            this.tbBoxWidth.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnArrow);
            this.groupBox1.Controls.Add(this.tbConeLength);
            this.groupBox1.Controls.Add(this.tbConeRadius);
            this.groupBox1.Controls.Add(this.tbCylLength);
            this.groupBox1.Controls.Add(this.tbCylRadius);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(14, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(154, 182);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arrow";
            // 
            // btnArrow
            // 
            this.btnArrow.Location = new System.Drawing.Point(12, 138);
            this.btnArrow.Name = "btnArrow";
            this.btnArrow.Size = new System.Drawing.Size(126, 32);
            this.btnArrow.TabIndex = 5;
            this.btnArrow.Text = "Arrow";
            this.btnArrow.UseVisualStyleBackColor = true;
            this.btnArrow.Click += new System.EventHandler(this.btnArrow_Click);
            // 
            // tbConeLength
            // 
            this.tbConeLength.Location = new System.Drawing.Point(85, 101);
            this.tbConeLength.Name = "tbConeLength";
            this.tbConeLength.Size = new System.Drawing.Size(54, 21);
            this.tbConeLength.TabIndex = 4;
            this.tbConeLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbConeRadius
            // 
            this.tbConeRadius.Location = new System.Drawing.Point(85, 74);
            this.tbConeRadius.Name = "tbConeRadius";
            this.tbConeRadius.Size = new System.Drawing.Size(54, 21);
            this.tbConeRadius.TabIndex = 3;
            this.tbConeRadius.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbCylLength
            // 
            this.tbCylLength.Location = new System.Drawing.Point(85, 47);
            this.tbCylLength.Name = "tbCylLength";
            this.tbCylLength.Size = new System.Drawing.Size(54, 21);
            this.tbCylLength.TabIndex = 2;
            this.tbCylLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbCylRadius
            // 
            this.tbCylRadius.Location = new System.Drawing.Point(85, 20);
            this.tbCylRadius.Name = "tbCylRadius";
            this.tbCylRadius.Size = new System.Drawing.Size(54, 21);
            this.tbCylRadius.TabIndex = 1;
            this.tbCylRadius.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "coneLength";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "coneRadius";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "cylLength";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "cylRadius";
            // 
            // design1
            // 
            this.design1.Cursor = System.Windows.Forms.Cursors.Default;
            this.design1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.design1.Location = new System.Drawing.Point(0, 0);
            this.design1.Name = "design1";
            this.design1.ProgressBar = progressBar3;
            this.design1.Size = new System.Drawing.Size(1236, 413);
            this.design1.TabIndex = 1;
            this.design1.Text = "design1";
            this.design1.Viewports.Add(viewport3);
            // 
            // Primitives
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 622);
            this.Controls.Add(this.design1);
            this.Controls.Add(this.panel1);
            this.Name = "Primitives";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.design1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnTorus;
        private System.Windows.Forms.TextBox tbMinorRadius;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tbMajorRadius;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox cbClose;
        private System.Windows.Forms.CheckBox cbReverseTwist;
        private System.Windows.Forms.Button btnSpring;
        private System.Windows.Forms.TextBox tbTurns;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbPitch;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbWireRadius;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbSpringRadius;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnSphere;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbSphereRadius;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnCylinder;
        private System.Windows.Forms.TextBox tbCylinderHeight;
        private System.Windows.Forms.TextBox tbCylinderRadius;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCone;
        private System.Windows.Forms.TextBox tbConeHeight;
        private System.Windows.Forms.TextBox tbBaseRadius;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbTopRadius;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBox;
        private System.Windows.Forms.TextBox tbBoxHeight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbBoxDepth;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbBoxWidth;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnArrow;
        private System.Windows.Forms.TextBox tbConeLength;
        private System.Windows.Forms.TextBox tbConeRadius;
        private System.Windows.Forms.TextBox tbCylLength;
        private System.Windows.Forms.TextBox tbCylRadius;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private devDept.Eyeshot.Design design1;
    }
}

