const app = Vue.createApp({
    data() {
        return {
            productName: 'Book a Cruise to the Moon',
            productDescription: 'Cruise to the moon in our luxurious shuttle. Watch the astronauts working outside the International Space Station.',
            productImage: './assets/cruise.jpg',
            productImageDescription: 'An astronaut floats outside the window while you sit in comfort',
            productImageStyle: {
                'border-radius': '15px'
            },
            itemsList: ['Susan', 'Peter', 'Bill', 'Mark', 'John', 'Alice'],
            productClasses: [
                {
                    name: 'Coach',
                    price: 125000,
                    seatsAvailable: 20,
                    earlyBird: true
                },
                {
                    name: 'Business',
                    price: 275000,
                    seatsAvailable: 6,
                    earlyBird: true
                },
                {
                    name: 'First',
                    price: 430000,
                    seatsAvailable: 2,
                    earlyBird: false
                }
            ],
            name: 'Cheryl',
            status: -1,
            active: false,
            benefitsSelected: 'yes',
            statusList: [
                'full-time',
                'part-time',
                'contractor'
            ],
            product: {
                name: 'Cruise to the moon',
                description: 'Cruise to the moon in our luxurious shuttle. Watch the astronauts working outside the International Space Station.',
                image: {
                    src: './assets/cruise.jpg',
                    description: 'An astronaut floats outside the window while you sit in comfort',
                    style: { 'border-radius': '15px' }
                },
                cabins: [
                    { name: 'Coach', price: 125000 },
                    { name: 'Business', price: 275000 },
                    { name: 'First', price: 430000 }
                ]
            },
            booking: {
                cabinIndex: 0,
                notes: '',
                completed: false
            }
        }
    }
});

app.mount('#app');