# Formatter
util lib that allows to get files extension from byte array or from give path.

Is a utility / library based on .Net which allows to easily recover the extension of a file from a byte array or from a path. it greatly facilitates the task for those who need to recover the extension of a file already converted into a byte array and saved in the database or even from the file path.
it also allows to format an image in the base64 format.

see below a little example on how to use it.

get file extension from bytes array:

```C#
 var imgArray = File.ReadAllBytes(@"..\Ambulance.jpg");
```
 ```C#
 var extension = FileHelper.GetExtension(imgArray);
 ```
 
 format image to base64 format allows for displaying in the src attribute by path 
   
   ```C#
   var formattedFile = FileHelper.Format(@"..\Ambulance.jpg");
   ```
   
   By byte array(image)
   ```C#
   var result = FileHelper.Format(byte[] file);
   ```
