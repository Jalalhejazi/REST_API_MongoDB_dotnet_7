# REST_NoSQL_MongoDB

## Why NoSQL? 

* NoSQL databases are highly preferred for large data sets (or) big data.
* NoSQL databases are preferred for cloud computing.
* NoSQL databases are open source and scalable.
* NoSQL databases are preferred for the hierarchical data storage.
* NoSQL databases are used in real-time web applications.
* NoSQL databases are highly preferred for the huge data set (i.e for big data).
* NoSQL databases are used for the huge traffic websites like Facebook, Twitter, etc.
* NoSQL databases are used for the huge data (i.e for big data).


## What is MongoDB?

* MongoDB is a cross-platform, document oriented database that provides, high performance, high availability, and easy scalability. MongoDB works on concept of collection and document.

* Database
    * Database is a physical container for collections. Each database gets its own set of files on the file system. A single MongoDB server typically has multiple databases.

* Collection

    * Collection is a group of MongoDB documents. It is the equivalent of an RDBMS table. A collection exists within a single database. Collections do not enforce a schema. Documents within a collection can have different fields. Typically, all documents in a collection are of similar or related purpose.

* Document

    * A document is a set of key-value pairs. Documents have dynamic schema. Dynamic schema means that documents in the same collection do not need to have the same set of fields or structure, and common fields in a collection's documents may hold different types of data.



## How to Run MongoDB on docker container? 

* Pull the mongo image from docker hub 

```bash
docker pull mongo
```

* Run the mongo image as a container and map the port 27017 to the host machine port 27017 

```bash
docker container run --name mongodb -d -p 27017:27017 mongo
```
Here, mongodb is the name of the container, and -p 27017:27017 maps port 27017 inside the container to port 27017 on your host machine. mongo is the name of the image we want to run. -d runs the container in detached mode, leaving the container running in the background. 

* Check the running containers

```bash
docker ps
```

* Connect to the mongo container 

```bash
docker exec -it mongodb bash
```

* Connect to the mongo shell 

```bash
mongo
```

* Create a database

```bash
use mydb
```

* Create a collection

```bash
db.createCollection('customers')
```

* Insert a document

```bash
db.customers.insertOne({name: 'John Doe'})
```

* Find a document

```bash
db.customers.find()
```

* Update a document

```bash
db.customers.updateOne({name: 'John Doe'}, {$set: {name: 'John Doe', age: 30}})
```

* Delete a document

```bash
db.customers.deleteOne({name: 'John Doe'})
```

* Delete a collection

```bash
db.customers.drop()
```

* Delete a database

```bash
db.dropDatabase()
```

* Exit from the mongo shell

```bash
exit
```

* Exit from the mongo container

```bash
exit
```

* Stop the mongo container

```bash
docker stop mongodb
```

* Remove the mongo container

```bash
docker rm mongodb
```

* Remove the mongo image

```bash
docker rmi mongo
```
