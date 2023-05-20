__confirm() {
    echo "拨号x86-1 ikuai-2"
    read -r -p "请选择 [1/2] " input
    case $input in
    1)
        echo "111"
        ;;

    2)
        echo "222"
        ;;
    esac
}
__confirm  
