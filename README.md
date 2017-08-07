# my-library
A windows form app that allows user to add to, update, and delete from a list of movies and books stored on a file.

The features of this application are similar to a database.
        ///     This application uses and MDI form to display a collection of records (specifically books and movies).
        ///     The user can:
        ///         -Insert records (individually, or several at a time if the author/director is the same)
        ///         -Update records (depending on the items selected in the form, will use the same form as insert but
        ///             with fields already entered, so to update, change data and hit ok)
        ///         -Delete records (again, depending on the items selected. It will ask for confimation before deleting)
        ///         -Search records (will search by title or author/director field only and highlight all matching records
        ///         -Order records by ascending/descending order (pres radio button to alternate:
        ///             -by title
        ///             -by author(then by release date)
        ///             -by release date
        ///             -by rating
        ///         -Since it allows multiple selection or records, a label will also tell the user how many are selected out of
        ///             how many are in the collection total
