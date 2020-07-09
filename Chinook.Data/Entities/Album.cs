using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chinook.Data
{
    public partial class Album
    {
        /// <summary>
        /// Album에서도 (Artist의 Id로) SearchWithArtistName의 메소드를 만들어 
        /// Artist의 이름을 알 수 있게하기 위해서 프로퍼티로 만들어준다.
        /// </summary>
        public string ArtistName { get; set; }
    }


    public string SearchWithArtistName()
}
