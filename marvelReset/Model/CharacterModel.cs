using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marvelReset.Model
{
    public class CharacterModel : BaseModel
    {
        private string _id;

        public string Id
        {
            get { return _id; }
            set
            {
                if (value != Id)
                {
                    _id = value;
                    OnPropertyChanged();
                }

            }
        }

        private string _name;

        public string Name
        {
            get { return _name; }
            set
            {
                if (value != Name)
                {
                    _name = value;
                    OnPropertyChanged();
                }

            }
        }
        private string _image;

        public string Image
        {
            get { return _image; }
            set
            {
                if (value != Image)
                {
                    _image = value;
                    OnPropertyChanged();
                }

            }
        }
        private string _description;

        public string Description
        {
            get { return _description; }
            set
            {
                if (value != Description)
                {
                    _description = value;
                    OnPropertyChanged();
                }

            }
        }
    }
}
