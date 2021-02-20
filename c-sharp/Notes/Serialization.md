## Serialization ##

- Process of converting an object into a stream of bytes to store the object or transmit to memory, a database, or a file
- Save the state of the object for later recreation (when needed);

## Deserialization ##

- Proceess of unpacking serialized objects

## Formats of Serialization ##

- Custom Binary (error prone) not recommended
- Custom text (has built in support in C#)
    -XML
    -JSON


- System.Runtime.Serialization contains classes that can be used for serializing and deserializing objects
- System.Text.Json contains classes that can be used to serialize objects into JSON format documents or streams
- System.Xml.Serialization contains classes that can be used to serialize objects into XML format douments or streams
