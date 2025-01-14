// server.js
const express = require('express');
const sqlite3 = require('sqlite3').verbose();
const cors = require('cors');
const app = express();
console.log("Server starting..."); //Added this line

const port = 5000; // Choose a port for the backend

app.use(cors()); // Enable CORS
app.use(express.json()); // Parse JSON request bodies

// Connect to SQLite database
const db = new sqlite3.Database('items.db', (err) => {
    if (err) {
        console.error('Error connecting to database', err);
    } else {
        console.log('Connected to the database');
        // Create the items table if it does not already exists
        db.run(`
            CREATE TABLE IF NOT EXISTS items (
                name TEXT PRIMARY KEY,
                price INTEGER
            );
       `,(createErr)=>{
            if (createErr) {
                console.error('Error creating items table:', createErr.message);
                } else {
                console.log('Items table created or already exists.');
              
                    db.get('SELECT COUNT(*) AS count FROM items', (countErr, row) =>{
                    if (countErr) {
                        console.error('Error checking the items table', countErr);
                       } else if (row.count == 0) {
                          db.serialize(() => { // Serialize queries to ensure they are executed in order
                            db.run('INSERT INTO items (name, price) VALUES (?, ?)', ['Espresso', 250]);
                            db.run('INSERT INTO items (name, price) VALUES (?, ?)', ['Americano', 300]);
                            db.run('INSERT INTO items (name, price) VALUES (?, ?)', ['Capuccino', 200]);
                            db.run('INSERT INTO items (name, price) VALUES (?, ?)', ['Tea', 100]);
                            db.run('INSERT INTO items (name, price) VALUES (?, ?)', ['Latte', 350]);
                        
                                console.log("Inserted dummy data")
                           });
                        }
                    });
                }
            });
        
    }
});


// API endpoint to get the price
app.get('/api/get-item-price', (req, res) => {
    const itemName = req.query.name;
    db.get('SELECT price FROM items WHERE name = ?', [itemName], (err, row) => {
        if (err) {
            res.status(500).send({ error: err.message });
            return;
        }
        if (row) {
            res.send({ price: row.price });
        } else {
            res.status(404).send({ error: 'Item not found.' });
        }
    });
});

// Start server
app.listen(port, () => {
    console.log(`Server running on port ${port}`);
});