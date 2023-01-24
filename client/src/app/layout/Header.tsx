import ShoppingCartIcon from '@mui/icons-material/ShoppingCart';
import {
	AppBar,
	Badge,
	Box,
	List,
	Switch,
	Toolbar,
	Typography,
} from '@mui/material';
import IconButton from '@mui/material/IconButton';
import ListItem from '@mui/material/ListItem';
import { NavLink } from 'react-router-dom';

interface Props {
	darkMode: boolean;
	handleThemeChange: () => void;
}

const midLinks = [
	{ title: 'catalog', path: '/catalog' },
	{ title: 'about', path: '/about' },
	{ title: 'contact', path: '/contact' },
];

const rightLinks = [
	{ title: 'login', path: '/login' },
	{ title: 'register', path: '/register' },
];

const navStyles = {
	color: 'inherit',
	textDecoration: 'none',
	typography: 'h6',
	'&:hover': {
		color: 'grey.300',
	},
	'&.active': {
		color: 'text.secondary',
	},
};

export default function Header({ darkMode, handleThemeChange }: Props) {
	return (
		<AppBar position="static" sx={{ mb: 4 }}>
			<Toolbar
				sx={{
					display: 'flex',
					justifyContent: 'space-between',
					alignItems: 'center',
				}}
			>
				<Box display="flex" alignItems="center">
					<Typography
						exact
						to="/"
						component={NavLink}
						variant="h6"
						sx={navStyles}
					>
						M&M
					</Typography>
					<Switch
						size="small"
						checked={darkMode}
						onChange={handleThemeChange}
						sx={{ ml: 1 }}
					/>
				</Box>

				<List sx={{ display: 'flex' }}>
					{midLinks.map(({ title, path }) => (
						<ListItem to={path} component={NavLink} key={path} sx={navStyles}>
							{title.toUpperCase()}
						</ListItem>
					))}
				</List>

				<Box display="flex" alignItems="center">
					<IconButton size="large" sx={{ color: 'inherit' }} aria-label="cart">
						<Badge badgeContent={4} color="secondary">
							<ShoppingCartIcon />
						</Badge>
					</IconButton>
					<List sx={{ display: 'flex' }}>
						{rightLinks.map(({ title, path }) => (
							<ListItem component={NavLink} to={path} key={path} sx={navStyles}>
								{title.toUpperCase()}
							</ListItem>
						))}
					</List>
				</Box>
			</Toolbar>
		</AppBar>
	);
}
