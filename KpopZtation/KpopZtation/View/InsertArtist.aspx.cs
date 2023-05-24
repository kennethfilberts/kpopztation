﻿using KpopZtation.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZtation.View
{
    public partial class InsertArtist : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void insertButton_Click(object sender, EventArgs e)
        {
            String name = artistNameBox.Text;
            HttpPostedFile postedFile = imageUpload.PostedFile;

            String warningText = ArtistController.createArtist(name, postedFile);
            warningLabel.Text = warningText;

            if (warningLabel.Text.Equals("Insert Successfuly !"))
            {
                Response.Redirect("HomePage.aspx");
            }
        }
    }
}