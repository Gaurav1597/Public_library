using System.Collections.Generic;

namespace Public_library
{
    internal class Resources
    {
        internal class Adpter_Books_Category_List
        {
            private Create_Book_Activity create_Book_Activity;
            private List<Tbl_Books_Category> list_All_Category;
            private Create_Category_Activity create_Category_Activity;
            private List<Tbl_Books_Category> list_Category;

            public Adpter_Books_Category_List(Create_Book_Activity create_Book_Activity, List<Tbl_Books_Category> list_All_Category)
            {
                this.create_Book_Activity = create_Book_Activity;
                this.list_All_Category = list_All_Category;
            }

            public Adpter_Books_Category_List(Create_Category_Activity create_Category_Activity, List<Tbl_Books_Category> list_Category)
            {
                this.create_Category_Activity = create_Category_Activity;
                this.list_Category = list_Category;
            }
        }

        internal class Adpter_Books
        {
            private Create_Book_Activity create_Book_Activity;
            private List<Tbl_Books> list_All_Books;

            public Adpter_Books(Create_Book_Activity create_Book_Activity, List<Tbl_Books> list_All_Books)
            {
                this.create_Book_Activity = create_Book_Activity;
                this.list_All_Books = list_All_Books;
            }
        }
    }
}