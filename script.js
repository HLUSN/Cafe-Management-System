document.addEventListener('DOMContentLoaded', function () {
    const itemNameInput = document.getElementById('itemName');
    const quantityInput = document.getElementById('quantity');
    const addOrderBtn = document.getElementById('addOrderBtn');
    const orderTableBody = document.getElementById('order-table-body');
    const orderListDiv = document.getElementById('order-list'); // Get the order list div
    let grandTotal = 0;

    // Function to look up price from the server-side API
    async function getItemPrice(itemName) {
        try {
             const response = await fetch(`http://localhost:5000/api/get-item-price?name=${itemName}`); // Port should match server port (5000)
             if (!response.ok) {
                throw new Error(`HTTP error! status: ${response.status}`);
             }

             const data = await response.json();
                return data.price;
         } catch (error) {
              console.error('Error fetching item price:', error);
                return 0; // Or handle the error as needed
         }
    }
    function updateGrandTotalDisplay(){
        let grandTotalElement = document.querySelector("#order-list + p");
        if (!grandTotalElement){
              grandTotalElement = document.createElement('p');
               orderListDiv.parentNode.insertBefore(grandTotalElement, orderListDiv.nextSibling);
          }
        grandTotalElement.textContent = `Grand Total: LKR ${grandTotal}`;
    }


    function addItemToTable(itemName, quantity) {
        getItemPrice(itemName).then(price => {
            const total = price * quantity;

            const newRow = orderTableBody.insertRow();
            newRow.setAttribute('data-item-name',itemName);
            const itemNameCell = newRow.insertCell();
            const quantityCell = newRow.insertCell();
            const priceCell = newRow.insertCell();
            const totalCell = newRow.insertCell();
            const actionsCell = newRow.insertCell();

            itemNameCell.textContent = itemName;
            quantityCell.textContent = quantity;
            priceCell.textContent = price;
            totalCell.textContent = total;

            const deleteButton = document.createElement('button');
            deleteButton.textContent = 'Delete';
            deleteButton.onclick = function () {
            deleteOrderItem(newRow);
            };
            const updateInput = document.createElement('input');
            updateInput.type = 'number';
            updateInput.value = quantity;
            updateInput.min = "1";
            updateInput.onchange = function () {
            updateOrderItem(newRow, updateInput.value);
            };

            actionsCell.appendChild(updateInput);
            actionsCell.appendChild(deleteButton);
            grandTotal += total;
            updateGrandTotalDisplay()
        });
    }

    function updateOrderItem(row, newQuantity) {
      const itemName = row.getAttribute('data-item-name');
        getItemPrice(itemName).then(price => {
           const quantityCell = row.cells[1];
             const totalCell = row.cells[3];
          const oldTotal = parseInt(totalCell.textContent);
            const newTotal = price * newQuantity;

            quantityCell.textContent = newQuantity;
            totalCell.textContent = newTotal;
          grandTotal += newTotal - oldTotal;
            updateGrandTotalDisplay()

        });

    }

    function deleteOrderItem(row) {
      const totalCell = row.cells[3];
      const rowTotal = parseInt(totalCell.textContent);
      grandTotal -=rowTotal;
        orderTableBody.deleteRow(row.rowIndex-1);
        updateGrandTotalDisplay()
    }

    addOrderBtn.addEventListener('click', function () {
        const itemName = itemNameInput.value.trim();
        const quantity = parseInt(quantityInput.value);
        if (itemName && quantity > 0 ) {
            addItemToTable(itemName, quantity);
            itemNameInput.value = ''; // Clear input after adding
            quantityInput.value = 1;
        } else {
            alert('Please enter a valid item name and quantity.');
        }
    });
});