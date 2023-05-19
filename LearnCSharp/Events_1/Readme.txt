Là thao tác của người dùng như nhấn nút, click, di chuyển chuột hoặc hệ thống tạo thông báo
Ứng dụng cần đáp ứng sự kiện khi xảy ra
Được sử dụng giữa các tiến trình

Sử dụng Delegate với Events
- Event được khai báo và được raise trong class, kết hợp với xử lý event sử dụng delegate bên trong class và những class khác
- Event sử dụng model publisher-subscriber
- Class chứa event được sử dụng để publish event, được gọi là publisher class. Một vài class khác accept event này được gọi là subscriber class
- Publisher là object chứa định nghĩa event và delegate. Sự kết hợp event-delegate cũng được định nghĩa trong class này. Publish class object gọi event và nó được thông báo đến object khác
- Subscriber là obejct accept event và cung cấp một handle event. Delegate trong publish class gọi method (handle event) của subscriber class