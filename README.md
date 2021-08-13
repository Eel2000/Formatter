# Formatter
util lib that allows to get files extension from byte array or from give path.

Is a utility / library based on .Net which allows to easily recover the extension of a file from a byte array or from a path. it greatly facilitates the task for those who need to recover the extension of a file already converted into a byte array and saved in the database or even from the file path.
it also allows to format an image in the base64 format displayable on an HTML page quite simply by passing the value returned by the library to the 'src' attribute of the 'img' tag and the image is displayed.
and you can even save the format returned by the library in the database in string format

see below a little example on how to use it.

get file extension from bytes array:

 <code> var imgArray = File.ReadAllBytes(@"C:\Users\CTRL TECH\Pictures\Ambulance.jpg");</code>
 <code>var extension = FileHelper.GetExtension(imgArray);</code>
 
 format image to base64 format allows for displaying in the src attribute by path 
   <code>var formattedFile = FileHelper.Format(@"C:\Users\CTRL TECH\Pictures\Ambulance.jpg");</code>
   
   By byte array(image)
   <code> var result = FileHelper.Format(byte[] file);</code>
