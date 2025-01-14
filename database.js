
import sqlite3 from 'sqlite3';

const db = new sqlite3.Database('./database.db', (err) => {
    if (err) {
        console.error('Error connecting to the database:', err.message);
    } else {
        console.log('Connected to the SQLite database.');
    }
});

const createProductsTable = `
  CREATE TABLE IF NOT EXISTS products (
    id INTEGER PRIMARY KEY AUTOINCREMENT,
    name TEXT NOT NULL,
    price INTEGER NOT NULL
  );
`;

db.run(createProductsTable, (err) => {
    if (err) {
        console.error('Error creating products table:', err.message);
    } else {
        console.log('Products table created successfully or already exists.');
    }
});


const createCartTable = `
  CREATE TABLE IF NOT EXISTS cart (
    id INTEGER PRIMARY KEY AUTOINCREMENT,
    name TEXT NOT NULL,
    quantity INTEGER NOT NULL,
    price INTEGER NOT NULL,
    total INTEGER NOT NULL
  );
`;

db.run(createCartTable, (err) => {
    if (err) {
        console.error('Error creating cart table:', err.message);
    } else {
        console.log('Cart table created successfully or already exists.');
    }
});

export default db;