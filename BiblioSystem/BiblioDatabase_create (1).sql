-- Created by Vertabelo (http://vertabelo.com)
-- Last modification date: 2020-04-19 18:14:30.491

-- tables
-- Table: Admin
CREATE TABLE Admin (
    id integer NOT NULL CONSTRAINT Admin_pk PRIMARY KEY AUTOINCREMENT,
    username varchar(20) NOT NULL,
    password varchar(30) NOT NULL
);

-- Table: Author
CREATE TABLE Author (
    id integer NOT NULL CONSTRAINT Author_pk PRIMARY KEY AUTOINCREMENT,
    username varchar(20) NOT NULL,
    password varchar(30) NOT NULL,
    name varchar(20) NOT NULL
);

-- Table: Citation
CREATE TABLE Citation (
    id integer NOT NULL CONSTRAINT Citation_pk PRIMARY KEY AUTOINCREMENT,
    publication_id integer NOT NULL,
    citation_author_id integer NOT NULL,
    CONSTRAINT Citation_Publication FOREIGN KEY (publication_id)
    REFERENCES Publication (id),
    CONSTRAINT Citation_Author FOREIGN KEY (citation_author_id)
    REFERENCES Author (id)
);

-- Table: Publication
CREATE TABLE Publication (
    id integer NOT NULL CONSTRAINT Publication_pk PRIMARY KEY AUTOINCREMENT,
    name varchar(50) NOT NULL
);

-- Table: Relation
CREATE TABLE Relation (
    id integer NOT NULL CONSTRAINT Relation_pk PRIMARY KEY AUTOINCREMENT,
    publication_id integer NOT NULL,
    author_id integer NOT NULL,
    CONSTRAINT Relation_Publication FOREIGN KEY (publication_id)
    REFERENCES Publication (id),
    CONSTRAINT Relation_Author FOREIGN KEY (author_id)
    REFERENCES Author (id)
);

-- End of file.

