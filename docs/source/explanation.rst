===========================
The structure of the schema
===========================

The goal of this project is to provide a JSON Schema that can be used to share data
between the stakeholders.

The schema is divided into several parts. First the `Metadata`_ with information about the data that is sent.
Next the `Farmer`_. A `Farmer`_ can have one or more `Farm`_. And a `Farm`_ can have one or more `Plot`_.

.. todo:: Show image to clarify

********
Metadata
********
The metadata gives the receiver some general information about the data that is being sent.

globalCoffeeDatasetId
^^^^^^^^^^^^^^^^^^^^^
Mandatory and makes the dataset unique.
The Id is defined as a `global-unique-id`_.

.. todo:: Show sample JSON

schemaVersion
^^^^^^^^^^^^^
The version number of the schema. When not provided the latest version of the schema will be used to validate the dataset.
An enumeration of possible version numbers is provided in the schema.

***********
Definitions
***********
global-unique-id
^^^^^^^^^^^^^^^^
This object is used a lot in this schema. It makes a data entity(`Farmer`_, `Farm`_ and `Plot`_) unique by providing 3 items:

* Organization: The name of the organization. This can be a name or number uniquely identifying the organization that issues this number. For example, 'RAINFOREST-ALLIANCE' when they issued the identifier or 'BURUNDI' when it is a national ID.
* Identifier: The identifier issued by the organization. This can be the Chamber of Commerce number or other number or string known by the organization.
* Timestamp: The timestamp when this identifier was created.

.. todo:: Show JSON of global-unique-id

thirdPartyIds
^^^^^^^^^^^^^^^^
This data entity is a list of `global-unique-id`_. And can be used when the receiving organization is inserting the data into their own system creating a new unique identifier. The original `global-unique-id`_ of this dataset can be saved in this thirdPartyIds entity. Because data can come from or via multiple organizations this list can grow, making the organizations in the chain aware of the identifiers used by others. This will help to identify the data entity and preventing duplicates.

.. todo:: Show JSON of thirdPartyIds

******
Farmer
******

****
Farm
****

****
Plot
****


**********
All todos
**********

.. todolist::
