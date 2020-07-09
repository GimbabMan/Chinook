using Chinook.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chinook.EF.Practices
{
    public partial class PracgrvAlbumListForm : Form
    {
        public PracgrvAlbumListForm()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            List<Album> albums = DataRepoistory.Album.GetAll();
            bdsAlbum.DataSource = albums;

            //foreach(Album album in albums)
            //{
            //    lsbTitle.Items.Add(album.Title);
            //}
        }
    }
}
