﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger;

public record class BookRecord ( string Author, string Title, int Isbn) : BaseEntity(Guid.NewGuid())
{
    //all implemented implicitly as the user should have access to basic members like author, title, and isbn
    public string Author { get; set; } = Author ?? throw new ArgumentNullException(nameof(Author));

    public string Title { get; set; } = Title ?? throw new ArgumentNullException(nameof(Title));

    public int Isbn { get; set; } = Isbn;

    public override string Name { get => $"{nameof(BookRecord)}:{Author}, {Title}"; }


    public override string ToString() => $"{Author}, {Title} - ISBN: {Isbn}";


}

