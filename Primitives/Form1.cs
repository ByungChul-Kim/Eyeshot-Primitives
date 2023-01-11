using devDept.Eyeshot.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primitives
{
    public partial class Primitives : Form
    {
        public Primitives()
        {
            InitializeComponent();
        }

        private void UpdateEntity(Entity entity)
        {
            design1.Entities.Clear();
            design1.Entities.Add(entity, Color.Aqua);
            design1.Invalidate();
            design1.ZoomFit();
        }
        
        private void btnArrow_Click(object sender, EventArgs e)
        {
            double cylRadius = Double.Parse(tbCylRadius.Text);
            double cylLength = Double.Parse(tbCylLength.Text);
            double coneRadius = Double.Parse(tbConeRadius.Text);
            double coneLength = Double.Parse(tbConeLength.Text);

            if (cylRadius * cylLength * coneRadius * coneLength <= 0)
                return;

            Mesh arrow = Mesh.CreateArrow(cylRadius, cylLength, coneRadius, coneLength, 24, devDept.Geometry.Entities.GMesh.natureType.Plain);
            UpdateEntity(arrow);
        }

        private void btnBox_Click(object sender, EventArgs e)
        {
            double width = Double.Parse(tbBoxWidth.Text);
            double depth = Double.Parse(tbBoxDepth.Text);
            double height = Double.Parse(tbBoxHeight.Text);

            Solid box = Solid.CreateBox(width, depth, height);

            UpdateEntity(box);
        }

        private void btnCone_Click(object sender, EventArgs e)
        {
            double baseRadius = Double.Parse(tbBaseRadius.Text);
            double topRadius = Double.Parse(tbTopRadius.Text);
            double height = Double.Parse(tbConeHeight.Text);

            Solid cone = Solid.CreateCone(baseRadius, topRadius, height, 24);
            UpdateEntity(cone);
        }

        private void btnCylinder_Click(object sender, EventArgs e)
        {
            double radius = Double.Parse(tbCylinderRadius.Text);
            double height = Double.Parse(tbCylinderHeight.Text);

            Solid cylinder = Solid.CreateCylinder(radius, height, 24);
            UpdateEntity(cylinder);
        }

        private void btnSphere_Click(object sender, EventArgs e)
        {
            double radius = Double.Parse(tbSphereRadius.Text);

            Solid sphere = Solid.CreateSphere(radius, 24, 24);
            UpdateEntity(sphere);
        }

        private void btnSpring_Click(object sender, EventArgs e)
        {
            double radius = Double.Parse(tbSpringRadius.Text);
            double wireRadius = Double.Parse(tbWireRadius.Text);
            double pitch = Double.Parse(tbPitch.Text);
            int turns = Int32.Parse(tbTurns.Text);
            bool reverseTwist = cbReverseTwist.Checked;
            bool closed = cbClose.Checked;

            Solid spring = Solid.CreateSpring(radius, wireRadius, 24, 24, pitch, turns, reverseTwist, closed);
            UpdateEntity(spring);
        }

        private void btnTorus_Click(object sender, EventArgs e)
        {
            double majorRadius = Double.Parse(tbMajorRadius.Text);
            double minorRadius = Double.Parse(tbMinorRadius.Text);

            Solid torus = Solid.CreateTorus(majorRadius, minorRadius, 24, 24);
            UpdateEntity(torus);
        }
    }
}
