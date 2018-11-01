
class Board extends React.Component {

    constructor(props) {
        super(props);
        this.state = {Dimension: 0, IsTerminal: false, BoardState: ''}
        this.handleBoardStateChange = this.handleBoardStateChange.bind(this);
        this.handleDimensionChange = this.handleBoardStateChange.bind(this);
        this.handleIsTerminalChange = this.handleBoardStateChange.bind(this);
    }

    loadDataFromServer() {
        const xhr = new XMLHttpRequest();
        xhr.open('get', this.props.url, true);
        xhr.onload = () => {
            const data = JSON.parse(xhr.responseText);
            this.handleDimensionChange();
            this.handleIsTerminalChange();
            this.handleBoardStateChange();
        }
        xhr.send(data);
    }

    componentWillMount() {
        this.loadDataFromServer();
        window.setInterval(
            () => this.loadDataFromServer(),
            this.props.pollInterval
        );
    }

    handleDimensionChange() {
        this.setState({ Dimension: e.target.value });
    }

    handleIsTerminalChange() {
        this.setState({ IsTerminal: e.target.value });
    }

    handleBoardStateChange() {
        this.setState({ BoardState: e.target.value });
    }

    render() {

    }

}

export default Board;